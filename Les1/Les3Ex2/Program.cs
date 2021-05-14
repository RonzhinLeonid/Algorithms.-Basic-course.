using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex2
{
    class Program
    {
        //Ронжин Л.
        //2. *Реализовать шейкерную сортировку.
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 4, 0, 3, 8, 5, 7, 6, 9 };
            int N = 0;
            SheikerSort(arr1, ref N);
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
        /// шейкерная сортировка
        /// </summary>
        /// <param name="array"></param>
        public static void SheikerSort(int[] array, ref int count)
        {
            Print(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                
                bool isChanged = false;
                for (var i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        count++;
                        Swap(ref array[i], ref array[i + 1]);
                        isChanged = true;
                    }
                }
                right--;
                for (var i = right; i > left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        count++;
                        Swap(ref array[i], ref array[i - 1]);
                        isChanged = true;
                    }
                }
                left++;
                Print(array);
                if (isChanged == false) break;
            }
        }
    }
}
