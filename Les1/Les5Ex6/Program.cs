using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex6
{
    class Program
    {
        //Ронжин Л.
        // ***Реализовать двустороннюю очередь.
        static void Main(string[] args)
        {
            Console.Write("Введите размер очереди: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nВведите число для проверки принадлежности списку: ");
            int a = int.Parse(Console.ReadLine());

            DoubleQueue<int> myQueue = new DoubleQueue<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) myQueue.AddFirst(i);
                else myQueue.AddLast(i);
            }
            Console.WriteLine();
            foreach (int s in myQueue)
                Console.Write(s + " ");
            Console.WriteLine();
            Console.WriteLine($"Пустой список? {myQueue.IsEmpty}");
            Console.WriteLine($"Последний элемент: {myQueue.Last}");
            Console.WriteLine($"Первый элемент: {myQueue.First}");
            Console.WriteLine($"Кол-во элементов списка: {myQueue.Count}");
            Console.WriteLine($"Принадлежит ли {a} очереди: {myQueue.Contains(a)}");
           
            Console.WriteLine($"\nУдален: {myQueue.DeleteFirst()}");
            Console.WriteLine($"Удален: {myQueue.DeleteLast()}");

            foreach (int s in myQueue)
                Console.Write(s + " ");

            myQueue.Clear();
            Console.WriteLine($"\nIsEmpty: {myQueue.IsEmpty}");
            Console.ReadKey();
        }
    }
}
