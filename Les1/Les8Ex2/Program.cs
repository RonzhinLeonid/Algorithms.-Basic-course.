using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Ex2
{
    //Ронжин Л.
    //2. Реализовать быструю сортировку.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int min = 0;
            int max = 20;
            GetRandomArray(ref arr, min, max);
            Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", QuickSort(arr)));
            Console.ReadLine();
        }
        /// <summary>
        /// метод для получения массива заполненного случайными числами
        /// </summary>
        /// <param name="arraySize"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static void GetRandomArray(ref int[] arraySize, int minValue, int maxValue)
        {
            var random = new Random();
            for (var i = 0; i < arraySize.Length; i++)
            {
                arraySize[i] = random.Next(minValue, maxValue);
            }
        }
        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        /// <summary>
        /// быстрая сортировка
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }
        /// <summary>
        /// метод возвращающий индекс опорного элемента
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        /// <summary>
        /// метод для обмена элементов массива
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }
}
