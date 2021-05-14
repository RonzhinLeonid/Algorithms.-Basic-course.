using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Реализовать перевод из десятичной в двоичную систему счисления с использованием стека
        static void Main()
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine()); 
            Stack<int> stack = new Stack<int>();
            Console.Write($"Число {n} в двоичной системе = "); 
            while (n > 0)
            {
                stack.Push(n % 2);
                n /= 2;
            }
            foreach (int i in stack) Console.Write(i);
            Console.ReadKey();
        }
    }
}
