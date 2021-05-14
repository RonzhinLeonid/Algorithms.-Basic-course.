using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        //Ронжин Л.
        //13. * Написать функцию, генерирующую случайное число от 1 до 100.
        //с использованием стандартной функции rand()
        //без использования стандартной функции rand()

        //Через милисекунды не очень хорошо выходит если брать ряд числел, но как взять более быстрое значение, к прямеру такт процессора, я пока не знаю
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write($"Случайное число с использованием стандартной функции rand():");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {rnd.Next(101)}");
            }
            Console.WriteLine();
            Console.Write($"Случайное число без использованиz стандартной функции rand():");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {Rand(101)}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// рандомайзер через милисекунды реального времени
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static int Rand(int N)
        {
            int x = DateTime.Now.Millisecond;
            int b = 3;
            int a = 2;
            int modulus = 100;
            int rez = 0;
            for (int i = 0; i < modulus; i++)
            {
                rez = (a * x + b) % N;
            }
            return rez;
        }
    }
}