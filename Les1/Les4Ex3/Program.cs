using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex3
{

    //Ронжин Л.
    //3. ***Требуется обойти конём шахматную доску размером NxM, пройдя через все поля доски по
    //одному разу.Здесь алгоритм решения такой же как и в задаче о 8 ферзях.Разница только в проверке
    //положения коня.

    class Program
    {
        static int[] arri = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] arrj = { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int[,] dock = new int[25, 25];
        static int n;
        //static int[,] Ar = new int[6, 6];
        //static int n;
        static int N = 5;
        static int M = 5;
        static int[,] board = new int[N,M];
        static void Main(string[] args)
            {
            Zero(N, M, board);
            SearchSolution(1);
            Print(N, M, board);
            Console.ReadKey();
            //return 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        int[,] Ar = new int[5, 5];
            //        int n = 0;
            //        Move(i, j, Ar, n);
            //        Console.WriteLine("-------------------------");
            //    }

            //}
            //int[,] Ar = new int[5, 5];
            //int n = 0;
            //Move(4, 4, Ar, n);
            //Console.ReadLine();

            //Console.WriteLine("Введите размер доски:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        dock[i, j] = 0;
            //        Console.Write(String.Format("{0,3}", dock[i, j]));
            //    }
            //    Console.WriteLine();
            //}

            //rekt(0, 0, 1);
            //Console.WriteLine("-------------------------------------------");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(String.Format("{0,3}", dock[i, j]));


            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();
        }

        static void rekt(int x, int y, int step)
        {
            dock[x, y] = step;
            for (int i = 0; i < 8; i++)
            {
                int x1 = x + arri[i];
                int y1 = y + arrj[i];
                if ((x1 >= 0) && (y1 >= 0) && (x1 < n) && (y1 < n) && (dock[x1, y1] == 0))
                    rekt(x1, y1, step + 1);
            }
        }

        static int SearchSolution(int n)
        {
            // Если проверка доски возвращает 0, то эта расстановка не подходит
            if (CheckBoard() == 0) return 0;
            // 9 ферзя не ставим. Решение найдено
            if (n == 15) return 1;
            int row;
            int col;
            for (row = 0; row < N; row++)
                for (col = 0; col < M; col++)
                {
                    if (board[row,col] == 0)
                    {
                        // Расширяем test_solution
                        board[row,col] = n;
                        // Рекурсивно проверяем, ведёт ли это к решению.
                        if (SearchSolution(n + 1) == 1) return 1;
                        // Если мы дошли до этой строки, данное частичное решение
                        // не приводит к полному
                        board[row,col] = 0;
                    }
                }
            return 0;
        }

        /// <summary>
        /// Проверка всей доски
        /// </summary>
        /// <returns></returns>
        static int CheckBoard()
        {
            int i, j;
            for (i = 0; i < N; i++)
                for (j = 0; j < M; j++)
                    if (board[i,j] != 0)
                        if (CheckQueen(i, j) == 0)
                            return 0;
            return 1;
        }

        /// <summary>
        /// Проверка определённого ферзя
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int CheckQueen(int x, int y)
        {
        int iX = 0, iY = 0;
            for (int k = 0; k < 8; k++)
            {
                switch (k)
                {
                    case 0: iX = x + 1; iY = y - 2; break;
                    case 1: iX = x + 2; iY = y + 1; break;
                    case 2: iX = x - 1; iY = y + 2; break;
                    case 3: iX = x - 2; iY = y - 1; break;
                    case 4: iX = x - 1; iY = y - 2; break;
                    case 5: iX = x + 2; iY = y - 1; break;
                    case 6: iX = x + 1; iY = y + 2; break;
                    case 7: iX = x - 2; iY = y + 1; break;
                }
                if (iX > -1 && iX < N && iY > -1 && iY < M && board[iX, iY] != 0) return 0;
            }

            //for (i = 0; i < N; i++)
            //for (j = 0; j < M; j++)
            //    // Если нашли фигуру
            //    if (board[i,j] != 0)
            //        if (!(i == x && j == y)) // Если это не наша фигура
            //        {
            //            // Лежат на одной вертикали или горизонтали
            //            if (i - x == 0 || j - y == 0) 
            //            return 0;
            //            // Лежат на одной диагонали
            //            if (Math.Abs(i - x) == Math.Abs(j - y))
            //            return 0;
            //        }
        // Если мы дошли до этого места, то всё в порядке
        return 1;
        }

        /// <summary>
        /// Очищаем доску
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="a"></param>
        static void Zero(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    a[i,j] = 0;
        }

        /// <summary>
        /// Выводим доску на экран
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="a"></param>
        static void Print(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(a[i,j] + " ");
                Console.WriteLine();
            }
        }



        static void Move(int X, int Y, int[,] Ar, int n)
        {
            int iX = 0, iY = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Ar[i, j] >= n && i != X && j != Y) Ar[i, j] = 0;
                }
            }
            bool step = false;
            Ar[X, Y] = ++n;
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0: iX = X + 1; iY = Y - 2; break;
                    case 1: iX = X + 2; iY = Y + 1; break;
                    case 2: iX = X - 1; iY = Y + 2; break;
                    case 3: iX = X - 2; iY = Y - 1; break;
                    case 4: iX = X - 1; iY = Y - 2; break;
                    case 5: iX = X + 2; iY = Y - 1; break;
                    case 6: iX = X + 1; iY = Y + 2; break;
                    case 7: iX = X - 2; iY = Y + 1; break;
                }
                if (iX > -1 && iX < 5 && iY > -1 && iY < 5 && Ar[iX, iY] == 0)
                {
                       Console.WriteLine("({0}):  {1}-{2}  ->   {3}-{4}", n, X + 1, Y + 1, iX + 1, iY + 1);
                        Print(5, 5, Ar);
                    //for (int z = 0; z < 5; z++)
                    //{
                    //    for (int j = 0; j < 5; j++)
                    //    {
                    //        if (Ar[z, j] > n && z != iX && j!=iY) Ar[z, j] = 0;
                    //    }
                    //}
                    Console.WriteLine("----");
                    Move(iX, iY, Ar, n);
                    step = true;
                }
            }
            if (!step)
            {
                n--;
                //Console.WriteLine("----");
                
                
                //Print(5, 5, Ar);
                //Console.WriteLine("----");
            }
        }



    }
}
