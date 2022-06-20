using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.lesson2
{
   public class Work1 : ILesson
    {
        public string Name => "2";

        public string Description => @"Требуется реализовать класс двусвязного списка и операции вставки, 
                                       удаления и поиска элемента в нём в соответствии с интерфейсом.";

        public void Run()
        {
            var duplexList = new DuplexLinkedList<int>();
            duplexList.AddNode(1);
            duplexList.AddNode(2);
            duplexList.AddNode(3);
            duplexList.AddNode(4);
            duplexList.AddNode(5);
            duplexList.AddNode(6);
            foreach (var item in duplexList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("-'Count'-" + duplexList.GetCount());
            Console.WriteLine();
            Console.Write("Удалить элемент - 3");
            duplexList.RemoveNode(3);

            Console.WriteLine();


            foreach (var item in duplexList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("-'Count'-" + duplexList.GetCount());
            Console.WriteLine();
            Console.Write("Удалить элемент - ");
            int a = int.Parse(Console.ReadLine());
            duplexList.RemoveNode(a);
            foreach (var item in duplexList)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("-'Count'-" + duplexList.GetCount());

            Console.ReadLine();
        }
    }
}
