using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
    class HomeWork1
    {
        public static void NumberCheck()
        {
            Console.Write("Введите число - ");
            int number = int.Parse(Console.ReadLine());
            while (number <= 1)
            {
                Console.WriteLine("Вы ввели число меньше одного,пожалуйста,повторите попытку.");
                number = int.Parse(Console.ReadLine());
            }


            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++; i++;
                }
                else
                    i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Ваше число простое.");
            }
            else
            {
                Console.WriteLine("Ваше число не простое");
            }


        }
    }
}
