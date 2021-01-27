using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Ex1
{
    //Ронжин Л.
    //1. Реализовать сортировку подсчетом.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int min = 0;
            int max = 20;
            GetRandomArray(ref arr, min, max);
            Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", CountingSort(arr, max)));
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
        /// <summary>
        /// простой вариант сортировки подсчетом
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max">Макс значение</param>
        /// <returns></returns>
        static int[] CountingSort(int[] array, int max)
        {
            int[] count = new int[max + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }
    }
}
