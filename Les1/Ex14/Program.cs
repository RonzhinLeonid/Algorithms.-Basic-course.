using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        //Ронжин Л.
        //14. * Автоморфные числа.Натуральное число называется автоморфным, если оно равно последним
        //цифрам своего квадрата.Например, 25 \ :sup: `2` = 625. Напишите программу, которая вводит
        //натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
        static void Main(string[] args)
        {
            int pLength = 1;
            int p = 1;
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Список автоморфных чисел в промежутке от 1 до {N}:");
            while (p <= N)
            {
                while (pLength <= p) pLength *= 10;

                if (Math.Pow(p, 2) % pLength == p) Console.Write($"{p} ");
                p++;
            }
            Console.ReadKey();
        }
    }
}