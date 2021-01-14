using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex4
{
    class Program
    {
        //Ронжин Л.
        //*Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
        static void Main(string[] args)
        {
            string str = "5*8*(2+9)+(7*5+8-9*(5*5)+5)";
            //string str = "5*6+(2-9)";
            Queue<char> queue = PostfixNotation(str);

            while (!(queue.Count == 0))
                Console.Write(queue.Dequeue());

            Console.ReadKey();
        }

        private static Queue<char> PostfixNotation(string str)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();
            foreach (char ch in str)
            {
                if (Char.IsNumber(ch))
                {
                    queue.Enqueue(ch);
                    continue;
                }

                if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^')
                {
                    if (stack.Count == 0 || stack.Peek() == '(')
                    {
                        stack.Push(ch);
                        continue;
                    }
                    if (GetPriority(ch) > GetPriority(stack.Peek())) stack.Push(ch);
                    if (GetPriority(ch) <= GetPriority(stack.Peek()))
                    {
                        if (!(stack.Count == 0))
                        {
                            while (!(stack.Peek() == '(') && !(GetPriority(ch) > GetPriority(stack.Peek())))
                            {
                                queue.Enqueue(stack.Pop());
                                if (stack.Count == 0) break;
                            }
                            stack.Push(ch);
                        }
                    };
                }
                if (ch == '(')
                {
                    stack.Push(ch);
                    continue;
                }
                if (ch == ')')
                {
                    if (!(stack.Count == 0))
                    {
                        while (!(stack.Peek() == '('))
                        {
                            queue.Enqueue(stack.Pop());
                            if (stack.Count == 0) break;
                        }
                        stack.Pop();
                    }
                }
            }
            while (!(stack.Count == 0))
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        static byte GetPriority(char s)
        {
            switch (s)
            {
                case '(':
                case ')':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 4;
            }
        }
    }
}
