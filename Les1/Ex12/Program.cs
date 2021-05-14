using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        //Ронжин Л.
        //12. Написать функцию нахождения максимального из трех чисел.
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимальное число из {a}, {b} и {c} - {MaxNumber(a, b, c)}.");
            Console.ReadKey();
        }

        /// <summary>
        /// Максимальное число из 3х
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static int MaxNumber(int a, int b, int c)
        {
            int max;
            if (a > b && a > c) max = a;
            else if (b > c) max = b;
            else max = c;
            return max;
        }
    }
}