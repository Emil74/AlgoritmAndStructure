using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson8
{
   internal class Task8
    {
     public   static void Sort(int[] arr, int lengt)
        {

            int[] output = new int[lengt];

            int[] count = new int[15];

            for (int i = 0; i < 15; ++i)
                count[i] = 0;

            for (int i = 0; i < lengt; ++i)
                ++count[arr[i]];

            for (int i = 1; i <= 14; i++)
                count[i] += count[i - 1];

            for (int i = lengt - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }


            for (int i = 0; i < lengt; i++)
                arr[i] = output[i];
        }

    }
}
