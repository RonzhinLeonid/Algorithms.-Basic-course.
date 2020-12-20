using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string str = "";
            TranslationDecToBin(N, ref str);
            Console.WriteLine($"в двоичной системе часло {N} равно {str}");
            Console.ReadKey();
        }

        static string TranslationDecToBin(int n, ref string s)
        {
            if (n > 0)
            { 
                TranslationDecToBin(n / 2, ref s) ;
                s += (n % 2).ToString();
            }
            else if (n == 0) return s; 
            return s;
        }

    }
}
