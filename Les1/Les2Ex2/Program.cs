using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2Ex2
{
    class Program
    {
        //Ронжин Л.
        //2. Реализовать функцию возведения числа a в степень b:
        //a.Без рекурсии.
        //b.Рекурсивно.
        //c. *Рекурсивно, используя свойство чётности степени.
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степнь: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}^{n} = {Pow_a(a,n)}");
            Console.WriteLine($"{a}^{n} = {Pow_b(a,n)}");
            Console.WriteLine($"{a}^{n} = {Pow_c(a,n)}");
            Console.ReadKey();
        }
        /// <summary>
        /// возведение в степень без рекурсии
        /// </summary>
        /// <param name="a">число</param>
        /// <param name="n">степень</param>
        /// <returns></returns>
        static double Pow_a(int a, int n)
        {
            double num_n = 1;
            if (n >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    num_n *= a;
                }
                return num_n; 
            }
            else
            {
                for (int i = 0; i < -n; i++)
                {
                    num_n *= a;
                }
                return 1/num_n;
            }
            
        }
        /// <summary>
        /// возведение в степень с рекурсией
        /// </summary>
        /// <param name="a">число</param>
        /// <param name="n">степень</param>
        /// <returns></returns>
        static double Pow_b(int a, int n)
        {
            if (n > 0) return a * Pow_b(a, n - 1);
            else if (n == 0) return 1;
            else return 1 / (a * Pow_b(a, -n - 1));
        }
        /// <summary>
        /// возведение в степень с рекурсией, используя свойство чётности степени.
        /// </summary>
        /// <param name="a">число</param>
        /// <param name="n">степень</param>
        /// <returns></returns>
        static double Pow_c(int a, int n)
        {
            if (n > 0)
            { 
                if (n % 2 == 0)
                {
                    var p = Pow_c(a, n / 2);
                    return p * p;
                }
                else return a * Pow_c(a, n - 1);
            }
            else if (n == 0) return 1;
            else return 1 / (a * Pow_b(a, -n - 1));
        }
    }
}
