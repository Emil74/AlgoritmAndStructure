using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите Урок (4 или 5) ");
            int urok = int.Parse(Console.ReadLine());
            switch (urok)
            {
                case 4:
                    Console.Write("Введите задание (1 или 2) - ");
                    int dz = int.Parse(Console.ReadLine());
                    if(dz==1)
                    HomeWork1.Work1();
                    if(dz==2)
                        HomeWork2.Work2();
                    break;
                case 5:
                    Lesson5.lesson5();
                    break;
                default:
                    break;
                    
            }
        }

    }
}

