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
            Console.WriteLine("Пожалуйста,введите пункт\n1.1 - Напишите на C# функцию согласно блок-схеме.\n1.2 - Реализуйте функцию вычисления числа Фибоначчи.");
            string selectednumber = (Console.ReadLine());
            switch (selectednumber)
            {
                case "1.1":
                    {
                        HomeWork1.NumberCheck();
                        Console.ReadLine();
                    }
                    break;


                case "1.2":
                    {
                        Console.WriteLine("Рекурсивно (10)- " + HomeWork2.Fibonacci(10));
                        Console.WriteLine("Без Рекурсивно (10)- " + HomeWork2.FibonacciNoRecursive(10));

                        Console.Write("Введите значение - ");
                        int number = int.Parse(Console.ReadLine());

                        Console.WriteLine("Рекурсивно - " + HomeWork2.Fibonacci(number));
                        Console.WriteLine("Без Рекурсивно - " + HomeWork2.FibonacciNoRecursive(number));
                        Console.ReadLine();
                    }
                    break;
            }
        }
    }
}
