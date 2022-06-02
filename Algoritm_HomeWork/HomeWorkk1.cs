using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
    class HomWorkk1
    {
        public static void NewMethod2()
        {
            Random rnd = new Random();
            HashSet<int> hashset = new HashSet<int>();
            int[] massiv = new int[1000000];

            Console.Write("Введите значение - ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000000; i++)
            {
                int k = rnd.Next(1, 1000000);
                hashset.Add(k);
                massiv[i] = k;
            }

            Console.Write("Тест Массив - ");
            Stopwatch stp = new Stopwatch();
            stp.Start();
            foreach (var item in massiv)
            {
                if (item.Equals(a))
                {
                    break;
                }
            }
            stp.Stop();

            TimeSpan time1 = stp.Elapsed;
            string tim1 = $"{time1.Hours}:{time1.Minutes}:{time1.Seconds}:{time1.Milliseconds} ms";
            Console.Write("RunTime " + tim1);

            Console.WriteLine();

            Console.Write("Тест HashSet - ");
            Stopwatch stopWatch = new Stopwatch();
            stp.Start();
            foreach (var item in hashset)
            {
                if (item.Equals(a))
                {
                    break;
                }
            }
            stp.Stop();

            TimeSpan time2 = stp.Elapsed;
            string tim2 = $"{time2.Hours}:{time2.Minutes}:{time2.Seconds}:{time2.Milliseconds} ms";
            Console.Write("RunTime " + tim2);

            Console.ReadLine();

        }
    }
}
