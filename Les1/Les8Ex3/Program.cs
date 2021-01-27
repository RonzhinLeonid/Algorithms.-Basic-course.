using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Ex3
{
    //Ронжин Л.
    //3. *Реализовать сортировку слиянием.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int min = 0;
            int max = 20;
            GetRandomArray(ref arr, min, max);
            Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", MergeSort(arr)));
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
        static int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }
        /// <summary>
        /// сортировка слиянием
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }
        /// <summary>
        /// метод для слияния массивов
        /// </summary>
        /// <param name="array"></param>
        /// <param name="lowIndex"></param>
        /// <param name="middleIndex"></param>
        /// <param name="highIndex"></param>
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}
