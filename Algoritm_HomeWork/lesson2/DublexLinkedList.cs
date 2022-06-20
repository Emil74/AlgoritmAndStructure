using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.lesson2
{
    public class DuplexLinkedList<T> : IEnumerable<T>

    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DuplexLinkedList()
        {

        }

        public DuplexLinkedList(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;

        }
        public int GetCount()
        {
            return Count;
        }

        public void AddNode(T data)
        {

            var item = new DuplexItem<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }


            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }



        public void RemoveNode(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }

                current = current.Next;
            }
        }


        public DuplexItem<T> FindNode(T searchValue)
        {
            DuplexItem<T> current = Head.Next;
            while (current != Tail)
            {
                current = current.Next;
            }
            if (current != Tail)
            {
                return current;
            }
            else
            {
                return null;
            }
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }


    }
}
