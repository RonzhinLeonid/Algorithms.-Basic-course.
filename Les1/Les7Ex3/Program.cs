using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Les7Ex4;

namespace Les7Ex3
{
    //Ронжин Л.
    //3. Написать функцию обхода графа в ширину
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = Library.ReadFile();
            Library.Print(matrix);
            Console.WriteLine("\nОбход графа в ширину с печатью вершин.");
            Library.WalkWidth(matrix);

            Console.ReadKey();
        }
    }
}
