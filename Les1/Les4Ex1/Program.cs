using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex1
{
    class Program
    {
        //Ронжин Л.
        //Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и
        //нахождение количество маршрутов
        //Например, карта:
        //3 3
        //1 1 1
        //0 1 0
        //0 1 0

        static void Main(string[] args)
        {
            int n = 3;
            int m = 3;
            int[,] map = {  {1,1,1},
                            {0,1,0},
                            {0,1,0} };
            
            int[,] arr = new int[n,m];
            for (int i = 0; i < m; i++)
            {
                arr[0, i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (map[i, 0] == 1) arr[i, 0] = 1;
                else arr[i, 0] = 0;

                for (int j = 1; j < m; j++)
                {
                    if (map[i, j] == 1) arr[i, j] = arr[i, j - 1] + arr[i - 1, j];
                    else arr[i, j] = 0;
                }
            }
            Print(arr);
            Console.ReadLine();
        }
        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
