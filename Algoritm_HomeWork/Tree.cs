using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork
{
    class Tree<T>
     where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }


        public void Delete(T data)
        {
            if (Root == null)
            {
                Console.WriteLine("Нет элемент");
            }
            Root.Delete(data);
            Count--;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Root.Preorder(Root);
        }



        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        public Node<T> GetNodeByValue(T data)
        {
            if (Root == null)
            {
                Console.WriteLine("Нет корен");
            }

            return Root.GetNodeByValuee(data);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }
    }
}
