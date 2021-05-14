using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les7Ex4
{
    public class Library
    {
        /// <summary>
        /// Проверка матрицы смежности
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static bool IsVerifyGraf(int[,] matrix)
        {
            int verticesCount = matrix.GetLength(0);
            if (verticesCount != matrix.GetLength(1))
            {
                Console.WriteLine("Ошибка! Матрица смежности неверной размерности!");
                return false;
            }
            bool error = false;
            for (int row = 0; row < verticesCount; row++)
            {
                if (matrix[row, row] != 0)
                    error = true;
                for (int col = row + 1; col < verticesCount; col++)
                    if (matrix[row, col] != matrix[col, row])
                    {
                        error = true;
                        break;
                    }
                if (error)
                    break;
            }
            if (error)
            {
                Console.WriteLine("Ошибка! Матрица смежности ошибочна!");
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Печать смежных вершин по вертикали
        /// </summary>
        /// <param name="Vert"></param>
        /// <param name="matrix"></param>
        static void PrintVert(int Vert, int[,] matrix)
        {
            Console.Write($"Вершина {Vert}. Смежна с вершинами:");
            int verticesCount = matrix.GetLength(0);
            for (int col = 0; col < verticesCount; col++)
                if (matrix[Vert, col] != 0)
                    Console.Write($"  {col}");
        }
        /// <summary>
        /// Обход графа в ширину
        /// </summary>
        /// <param name="matrix"></param>
        public static void WalkWidth(int[,] matrix)
        {
            if (!IsVerifyGraf(matrix))
                return;

            int verticesCount = matrix.GetLength(0);

            List<int> vertList = new List<int>();
            Queue<int> vertQueue = new Queue<int>();

            for (int vert = 0; vert < verticesCount; vert++)
            {
                int vertCurr = vert;
                while (true)
                {
                    if (vertList.IndexOf(vertCurr) < 0)
                    {
                        PrintVert(vertCurr, matrix);
                        Console.WriteLine();
                        vertList.Add(vertCurr);

                        for (int col = 0; col < verticesCount; col++)
                            if (matrix[vertCurr, col] != 0 && vertList.IndexOf(col) < 0)
                                vertQueue.Enqueue(col);
                    }

                    if (vertQueue.Count == 0)
                        break;

                    vertCurr = vertQueue.Dequeue();
                }

            }

        }
        /// <summary>
        /// Обход графа в глубину
        /// </summary>
        /// <param name="matrix"></param>
        public static void WalkDeep(int[,] matrix)
        {
            if (!IsVerifyGraf(matrix))
                return;

            int verticesCount = matrix.GetLength(0);

            List<int> vertList = new List<int>();
            Stack<int> vertStack = new Stack<int>();

            for (int vert = 0; vert < verticesCount; vert++)
            {
                int vertCurr = vert;
                while (true)
                {
                    if (vertList.IndexOf(vertCurr) < 0)
                    {
                        PrintVert(vertCurr, matrix);
                        Console.WriteLine();
                        vertList.Add(vertCurr);

                        for (int col = 0; col < verticesCount; col++)
                            if (matrix[vertCurr, col] != 0 && vertList.IndexOf(col) < 0)
                                vertStack.Push(col);
                    }

                    if (vertStack.Count == 0)
                        break;

                    vertCurr = vertStack.Pop();
                }
            }
        }
        /// <summary>
        /// Вывод матрицы в консоль
        /// </summary>
        /// <param name="matrix"></param>
        public static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Чтение матрицы из файла
        /// </summary>
        /// <returns></returns>
        public static int[,] ReadFile()
        {
            StreamReader sr = new StreamReader("Data.txt");
            int n = Convert.ToInt32(sr.ReadLine());
            int[,] matrix = new int[n, n];
            int k = 0;
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(' ');
                    for (int i = 0; i < n; i++)
                    {
                        matrix[k, i] = Convert.ToInt32(s[i]);
                    }
                    k++;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                }
            }
            sr.Close();
            return matrix;
        }
    }
}
