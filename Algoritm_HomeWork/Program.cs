using Algoritm_HomeWork.lesson_3;
using Algoritm_HomeWork.lesson2;
using Algoritm_HomeWork.Lesson8;
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
            new Work1(),
            new Struct_Class(),
            new lesson8()
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
                     
        }

    }
}

