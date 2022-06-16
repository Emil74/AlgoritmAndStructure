using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
    class HomeWork2
    {
        public static void Work2()
        {
            ConsoleKeyInfo key;
            var tree = new Tree<int>();
            tree.Add(4);
            tree.Add(1);
            tree.Add(3);
            tree.Add(6);
            tree.Add(5);
            tree.Add(7);
            tree.Add(9);
            //  tree.Add(8);
            tree.Add(10);

            foreach (var item in tree.Preorder())
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Можно удалить (3,10,5)  их нет ребенки");
            do
            {
                Console.WriteLine("1 - Удалить элемент ");
                Console.WriteLine("2 - Получить узел дерева по значению");
                Console.WriteLine("3 - Сортировка ");
                Console.WriteLine();
                Console.Write("Введите значение - ");
                int data = int.Parse(Console.ReadLine());
                switch (data)
                {
                    case 1:
                        Console.WriteLine("Можно удалить (10,5)  их нет ребенки");
                        Console.Write("Какой элемент вы хотите удалить - ");

                        int a = int.Parse(Console.ReadLine());
                        tree.Delete(a);
                        foreach (var item in tree.Preorder())
                        {
                            Console.Write(item + ", ");
                        }
                        Console.WriteLine();

                        break;
                    case 2:
                        Console.Write("Получить узел дерева по значению например (7) ");
                        tree.GetNodeByValue(7);
                        Console.WriteLine();
                        Console.Write("Получить узел дерева Введите значение - ");
                        int value = int.Parse(Console.ReadLine());
                        tree.GetNodeByValue(value);
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.Write("Сортировка - ");

                        foreach (var item in tree.Inorder())
                        {
                            Console.Write(item + ", ");
                        }
                        Console.WriteLine();

                        break;
                    default:
                        break;

                }
                Console.WriteLine("Если хотите завершить программу нажмите любую другую кнопку...");
                Console.Write("Если хотите повторить программу нажмите R \n");
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.R);

            Console.ReadLine();
        }
    }
}
