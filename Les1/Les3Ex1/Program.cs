using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения
        //оптимизированной и не оптимизированной программы. Написать функции сортировки, которые
        //возвращают количество операций.

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 4, 0, 3, 8, 5, 7, 6, 9 };
            int N = 0;
            BubbleSort(arr1, ref N);
            Console.WriteLine(N);
            int[] arr2 = new int[] { 1, 2, 4, 0, 3, 8, 5, 7, 6, 9 };
            N = 0;
            BubbleSortOptimaiz(arr2, ref N);
            Console.WriteLine(N);

            Console.ReadKey();
        }
        /// <summary>
        /// Вспомогательный метод, "меняет местами" два элемента
        /// </summary>
        /// <param name="a"></param>
        /// <param name="aSecondArg"></param>
        public static void Swap(ref int a, ref int b)
        {
            int tmpParam = a;
            a = b;
            b = tmpParam;
        }
        /// <summary>
        /// Вывод массива на кансоль
        /// </summary>
        /// <param name="array"></param>
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// сортировка пузырьком
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(int[] array, ref int count)
        {
            
            Print(array);
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        count++;
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
                Print(array);
            }
        }
        /// <summary>
        /// сортировка пузырьком
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortOptimaiz(int[] array, ref int count)
        {
            Print(array);
            for (int i = 0; i < array.Length; i++)
            {
                bool isChanged = false;
                count++;
                for (int j = 0; j < array.Length - 1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        count++;
                        Swap(ref array[j], ref array[j + 1]);
                        isChanged = true;
                    }
                }
                Print(array);
                if (isChanged == false) break;
            }
        }
    }
}
