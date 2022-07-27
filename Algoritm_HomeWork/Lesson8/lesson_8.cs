using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson8
{
    internal class lesson_8
    {
        public static void Sort(int[] arr)
        {
            int lengt = arr.Length;

            // отсортированный массив
            int[] output = new int[lengt];

            //Создать массив для хранения
            int[] count = new int[lengt];

            for (int i = 0; i < lengt; i++)
                count[i] = 0;

            // сохраняем  каждый символ
            for (int i = 0; i < lengt; i++)
                count[arr[i]]++;

            for (int i = 1; i < lengt; i++)
                count[i] += count[i - 1];


            // Создаем массив выходных символов
            // Работаем в обратном порядке 
            for (int i = lengt - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            //Копируем выхыодной массив в arr
            for (int i = 0; i < lengt; i++)
                arr[i] = output[i];
        }

    }
}
