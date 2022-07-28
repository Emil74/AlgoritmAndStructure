using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_HomeWork.Lesson7
{
    public class Board
    {
        const int N = 8;
        public static void Run()
        {
            int count = 0;

            int[,] board = new int[N, N];

            //Инициализируем массив платы значением 0

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    board[i, j] = 0;
                }
            }

            //Инициализируем массив указателей

            int[] pointer = new int[N];

            for (int i = 0; i < N; i++)
            {
                pointer[i] = -1;
            }

            //Реализация алгоритма обратного отслеживания
            int k = 0;
            while (true)
            {
                pointer[k]++;

                // Сброс и перемещение на один столбец назад

                if (pointer[k] == N)
                {
                    board[pointer[k] - 1, k] = 0;

                    pointer[k] = -1;

                    k--;

                    if (k == -1)
                    {
                        Console.WriteLine("все возможные решения проблемы N-Queens сделаны");
                        break;
                    }
                }
                else
                {
                    board[pointer[k], k] = 1;

                    if (pointer[k] != 0)
                    {
                        board[pointer[k] - 1, k] = 0;
                    }

                    if (SolutionCheck(board))
                    {
                        k++;// перейти к следующему столбцу

                        if (k == N)
                        {
                            k--;
                            count++;

                            Console.WriteLine("Выбор" + count.ToString() + ":");

                            for (int p = 0; p < N; p++)
                            {
                                for (int q = 0; q < N; q++)
                                {
                                    Console.Write(board[p, q] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        public static bool SolutionCheck(int[,] board)
        {
            //Проверка строки

            for (int i = 0; i < N; i++)
            {
                int sum = 0;

                for (int j = 0; j < N; j++)
                {
                    sum = sum + board[i, j];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //Проверка главной диагонали

            for (int i = 0, j = N - 2; j >= 0; j--)
            {
                int sum = 0;

                for (int p = i, q = j; q < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //ниже

            for (int i = 1, j = 0; i < N - 1; i++)
            {
                int sum = 0;

                for (int p = i, q = j; p < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }

                if (sum > 1)
                {
                    return false;
                }
            }

            //Проверка малой диагонали

            //выше

            for (int i = 0, j = 1; j < N; j++)
            {
                int sum = 0;

                for (int p = i, q = j; q >= 0; p++, q--)
                {
                    sum = sum + board[p, q];
                }

                if (sum > 1)
                {
                    return false;
                }
            }

            //ниже

            for (int i = 1, j = N - 1; i < N - 1; i++)
            {
                int sum = 0;

                for (int p = i, q = j; p < N; p++, q--)
                {
                    sum = sum + board[p, q];
                }

                if (sum > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
