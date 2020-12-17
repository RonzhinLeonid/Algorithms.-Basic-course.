using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        //Ронжин Л.
        //10. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления
        //определить, имеются ли в записи числа N нечетные цифры.Если имеются, то вывести True, если нет
        //— вывести False
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            bool even = true;
            while (N > 0)
            {
                if (N % 10 % 2 != 0)
                {
                    even = false;
                    break;
                }
                N = N / 10;
            }
            Console.WriteLine(even ? "True" : "False");
            Console.ReadKey();
        }
    }
}
