using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ронжин Л.
            //3. Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной; 
            // б) *без использования третьей переменной. 
            Console.Write("Вариант а.\nУкажите 1ю переменную: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите 2ю переменную: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"\nПервая переменная: {a}.\nВторая переменная: {b}.");


            Console.WriteLine("\nВариант б. Те же значения обратно.");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Первая переменная: {a}.\nВторая переменная: {b}.");
            Console.ReadKey();
        }
    }
}
