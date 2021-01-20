using System;
using Les7Ex4;

namespace Les7Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран
        static void Main(string[] args)
        {
            int[,] matrix = Library.ReadFile();
            Library.Print(matrix);

            Console.ReadKey();
        }
    }
}
