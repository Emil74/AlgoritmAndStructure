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
            Console.Write(" Введите Урок 4 задание 1 или 2 ");
            int dz = int.Parse(Console.ReadLine());
            switch (dz)
            {
                case 1:
                    HomWorkk1.NewMethod2();
                    break;
                case 2:
                    HomeWorkk2.NewMethod2();
                    break;
                default:
                    break;
            }
        }
    }
}
