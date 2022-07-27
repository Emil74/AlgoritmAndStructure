using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson6
{
    class Work6 : ILesson
    {
        public string Name => "6";

        public string Description => "Реализовать загрузку списка уроков из файла.";

        public void Run()
        {
            string userEnter;
            var homeList = Louncher.GetList();
            if (homeList.Length > 0)
            {

                do
                {
                    for (int i = 0; i < homeList.Length; i++)
                    {
                        Console.WriteLine($" {homeList[i]}");
                    }
                    Console.Write("Введите задание для выход -1");
                    userEnter = Console.ReadLine();
                    if (int.TryParse(userEnter, out int userChoice))
                    {
                        if (userChoice - 1 < homeList.Length && userChoice > 0)
                        {
                            Louncher.Run(userChoice - 1);
                        }
                    }

                } while (userEnter != "-1");

            }
        }

    }
}
