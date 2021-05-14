using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        //Ронжин Л.
        //11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех
        //положительных четных чисел, оканчивающихся на 8.
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            int count = 0;
            while (true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) break;
                if (a > 0 && a % 10 == 8)
                {
                    count++;
                    sum += a;
                }
            }
            Console.WriteLine( (double)sum/count);
            Console.ReadKey();
        }
    }
}
