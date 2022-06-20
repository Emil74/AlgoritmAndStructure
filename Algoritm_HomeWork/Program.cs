using Algoritm_HomeWork.lesson2;
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
            List<ILesson> task = new List<ILesson>()
            {
            new Lesson5(),
            new HomeWork2(),
            new Work1()
            };

            foreach (ILesson lesson in task)
                Console.WriteLine($"Введите '{lesson.Name}' для вызова задания '{lesson.Description}' ");

            Console.Write("Input task number - ");
            string taskNumber = Console.ReadLine();
            foreach (ILesson lesson in task)
            {
                if (lesson.Name == taskNumber)
                    lesson.Run();
            }
            

         /*   Console.Write("Введите Урок (4 или 5) ");
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
                    
            }*/
        }

    }
}

