using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson8
{
   public class lesson8 : ILesson
    {
        public string Name => "8";

        public string Description => "Реализовать алгоритм сортировки подсчетом";

        public void Run()
        {
            int[] arr = { 1, 2, 5, 4, 7, 8, 9, 5, 1, 2, 3, 6, 4, 6 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
           Task8.Sort(arr, arr.Length);
            Console.WriteLine();
            Console.WriteLine("Сортировка ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i]+" ");
            Console.ReadLine();
        }
    }
}
