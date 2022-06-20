using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.lesson2
{
    public interface ILinkedList<T>
    {
        int GetCount();                             // возвращает количество элементов в списке
        void AddNode(T value);                    // добавляет новый элемент списка      
        void RemoveNode(T index);                 // удаляет элемент по порядковому номеру       
    }
}
