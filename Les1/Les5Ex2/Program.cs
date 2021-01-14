using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex2
{
    class Program
    {
        //Ронжин Л.
        //Написать программу, которая определяет, является ли введенная скобочная
        //последовательность правильной.Примеры правильных скобочных выражений: (), ([])(), { } (),
        //([{}]), неправильных — )(, ()) ({), (, ])}), ([(]) для скобок[, (, {.
        //Например: (2 + (2 * 2)) или[2 /{ 5 * (4 + 7)}].

        static void Main()
        {
            //string str = "(1)({[]()}[])";
            //string str = "(2+(2*2))";
            //string str = ")[2/{5*(4+7)}]";
            Console.Write("Введите последовательность: ");
            string str = Console.ReadLine();
            Console.WriteLine((BracketsChecker(str) ? "П" : "Неп")+ "равильная последовательность");
            Console.ReadKey();
        }

        private static bool BracketsChecker(string str)
        {
            string opening = "([{";
            string closing = ")]}";

            Stack<int> stack = new Stack<int>();

            foreach (var ch in str)
            {
                int index = opening.IndexOf(ch);
                if (index != -1)
                {
                    stack.Push(index);
                }

                index = closing.IndexOf(ch);
                if (index != -1)
                {
                    if (stack.Count == 0 || stack.Peek() != index)
                    {
                        stack.Clear();
                        stack.TrimExcess();
                        return false;
                    }
                    stack.Pop();
                }
            }
            return true;
            
        }
    }
}
