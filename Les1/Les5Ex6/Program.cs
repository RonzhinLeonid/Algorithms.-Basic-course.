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

            DoubleQueue<int> usersDeck = new DoubleQueue<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) usersDeck.AddFirst(i);
                else usersDeck.AddLast(i);
            }
            Console.WriteLine();
            foreach (int s in usersDeck)
                Console.Write(s + " ");
            Console.WriteLine();
            Console.WriteLine($"Пустой список? {usersDeck.IsEmpty}");
            Console.WriteLine($"Последний элемент: {usersDeck.Last}");
            Console.WriteLine($"Первый элемент: {usersDeck.First}");
            Console.WriteLine($"Кол-во элементов списка: {usersDeck.Count}");
            Console.WriteLine($"Принадлежит ли {a} очереди: {usersDeck.Contains(a)}");
           
            Console.WriteLine($"\nУдален: {usersDeck.DeleteFirst()}");
            Console.WriteLine($"Удален: {usersDeck.DeleteLast()}");

            foreach (int s in usersDeck)
                Console.Write(s + " ");

            usersDeck.Clear();
            Console.WriteLine($"\nIsEmpty: {usersDeck.IsEmpty}");
            Console.ReadKey();
        }
    }
}
