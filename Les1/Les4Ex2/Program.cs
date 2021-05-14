using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex2
{
    class Program
    {
        //Ронжин Л.
        //Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
        static void Main(string[] args)
        {
            //int[] x = { 1, 5, 4, 2, 3, 7, 6 };
            //int[] y = { 2, 7, 1, 3, 5, 4, 6 };
            string[] x = { "g", "e", "e", "k", "b", "r", "a", "i" , "n", "s" };
            string[] y = { "g", "e", "e", "k", "m", "i", "n", "d", "s" };

            int m = x.Length;
            int n = y.Length;
            int[,] len = new int[m + 1, n + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x[i] == y[j])
                    {
                        len[i + 1, j + 1] = len[i, j] + 1;
                    }
                    else
                    {
                        len[i + 1, j + 1] = Math.Max(len[i + 1, j], len[i, j + 1]);
                    }
                }
            }
            Console.Write("    ");
            Print(x);
            Console.WriteLine();
            for (int i = 0; i < len.GetLength(1); i++)
            {
                if (i-1!=-1 && i-1<y.Length) Console.Write(y[i-1] + " ");
                else Console.Write("  ");
                for (int j = 0; j < len.GetLength(0); j++)
                {
                    Console.Write(len[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int cnt = len[m, n];
            string[] res = new string[cnt];
            for (int i = m - 1, j = n - 1; i >= 0 && j >= 0;)
            {
                if (x[i] == y[j])
                {
                    res[--cnt] = x[i].ToString();
                    --i;
                    --j;
                }
                else if (len[i + 1, j] > len[i, j + 1])
                {
                    --j;
                }
                else
                {
                    --i;
                }
            }

            Print(res);
            Console.ReadLine();

        }
        public static void Print(string[] array)
        {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(array[j] + " ");
                }
        }
        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
