using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex3
{
    class Program
    {
        //ронжин Л.
        //3. Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный
        //массив. Функция возвращает индекс найденного элемента или -1, если элемент не найден.
        static void Main(string[] args)
        {
            int[] array = new int[] {3, 4, 5, 6, 7, 8, 9 };
            Print(array);
                Console.Write("Введите искомое значение: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int searchResult = BinarySearch(array, n, 0, array.Length - 1);
            Console.WriteLine($"Элемент найден. Индекс элемента со значением {n} равен {searchResult}");
            Console.ReadLine();
        }

        /// <summary>
        /// Рекурсивный бинарный поиск
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchedValue"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        static int BinarySearch(int[] array, int searchedValue, int left, int right)
        {
            if (left > right) return -1; //если лево и право сошлись
            int middle = (left + right) / 2;
            if (array[middle] == searchedValue) return middle;  //результат
            else if (array[middle] > searchedValue) return BinarySearch(array, searchedValue, left, middle - 1); //продолжение поиска в левой части массива
            else return BinarySearch(array, searchedValue, middle + 1, right); //продолжение поиска в правой части массива
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
    }
}
