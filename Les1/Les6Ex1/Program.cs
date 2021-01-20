using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов символов
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            Console.Write(Hash(str));
            Console.ReadKey();
        }
        /// <summary>
        /// Хэш-функция
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Hash(string x)
        {
            int rez = 0;
            for (int i = 0; i < x.Length; i++)
            {
                int temp = x[i];
                rez += temp*2 + temp%2+3;
            }
            return rez;
        }
    }
}
