
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkk6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string userEnter;
            var homeList = Louncher.GetList();
            if (homeList.Length>0)
            {
                
                do
                {
                    for (int i = 0; i < homeList.Length; i++)
                    {
                        Console.WriteLine($"{i+1} {homeList[i]}");
                    }
                    Console.Write("Введите задание для выход -1");
                    userEnter = Console.ReadLine();
                    if (int.TryParse(userEnter,out int userChoice))
                    {
                        if (userChoice-1<homeList.Length&&userChoice>0)
                        {
                            Louncher.Run(userChoice-1);
                        }
                    }

                } while (userEnter!="-1");
                
            }
            Console.ReadLine();
        }
        
    }
}
