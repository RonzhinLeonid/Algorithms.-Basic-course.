using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Ex4
{
    //Ронжин Л.
    //4. **Реализовать алгоритм сортировки со списком
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int min = 0;
            int max = 20;
            GetRandomArray(ref arr, min, max);
            Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", PigeonholeSort(arr)));
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
        /// сортировка со списком
        /// </summary>
        /// <param name="array"></param>
        static int[] PigeonholeSort(int[] array)
        {
            int length = array.Length;

            //Поиск диапазона массива
            int min = array.Min();
            int max = array.Max();
            int range = max - min + 1;

            //Массив значений
            int[] pigeonholes = new int[range];
            for (int i = 0; i < pigeonholes.Length; i++)
            {
                pigeonholes[i] = 0;
            }

            //Для каждого значения в массиве отмечаем сколько раз индекс ячейки появляется в корневом массиве
            for (int i = 0; i < length; i++)
            {
                pigeonholes[array[i] - min]++;
            }

            int index = 0;

            //Используем массив для сортировки основного массива
            for (int j = 0; j < range; j++)
            {
                while (pigeonholes[j]-- > 0)
                {
                    array[index] = j + min;
                    index++;
                }
            }
            return array;
        }
    }
}
