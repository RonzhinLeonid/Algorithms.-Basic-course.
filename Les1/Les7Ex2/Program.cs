using System;
using System.Collections.Generic;
using Les7Ex4;

namespace Les7Ex2
{
    class Program
    {
        //Сергей с рекурсией возникли трудности, сделал функцию без рекурсии.
        //Ронжин Л.
        //2. Написать рекурсивную функцию обхода графа в глубину.
        static public void Main()
        {
            int[,] matrix = Library.ReadFile();
            Library.Print(matrix);
          
            Console.WriteLine("\nОбход графа в глубину с печатью вершин.\n");
            Library.WalkDeep(matrix);

            Console.ReadKey();
        }
        
    }
}
