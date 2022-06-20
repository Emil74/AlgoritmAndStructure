using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
    class Lesson5:ILesson
    {
        public string Name => "5";

        public string Description => " поиска в дереве 'поиск в ширину' и 'поиск в глубину' ";
       

        public void Run()
        {
           /* public static void lesson5()
            {*/
                var tree = new Tree<int>();
                tree.Add(4);
                tree.Add(1);
                tree.Add(3);
                tree.Add(6);
                tree.Add(5);
                tree.Add(7);
                tree.Add(9);
                tree.Add(8);
                tree.Add(10);


                foreach (var item in tree.Preorder())
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("\n");
                Console.Write("Введите значение - ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("BFS-->");
                tree.bfs(a);
                Console.WriteLine("\n");
                Console.WriteLine("DFS-->");
                tree.dfs(a);

                Console.ReadLine();
            }
       // }
    }
}
