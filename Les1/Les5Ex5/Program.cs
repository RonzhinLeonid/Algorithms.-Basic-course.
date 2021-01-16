using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex5
{
    class Program
    {
        //Ронжин Л.
        //Реализовать очередь:
        //1. С использованием массива.
        //2. *С использованием односвязного списка.
        static void Main(string[] args)
        {
            Console.Write("Введите размер очереди: ");
            int n = int.Parse(Console.ReadLine());

            QueueArray myQueue = new QueueArray();
            for (int i = 0; i < n; i++)
            {
                myQueue.Enqueue(i);
            }

            Console.WriteLine();
            Console.WriteLine($"Пустой список? {myQueue.IsEmpty}");
            Console.WriteLine($"Кол-во элементов списка: {myQueue.Count}");
            Console.WriteLine($"Вершина очереди: {myQueue.Peek()}");
            // Извлекаем элементы
            while (myQueue.Count > 0)
                Console.Write(myQueue.Dequeue() + " ");

            Console.WriteLine($"\nIsEmpty: {myQueue.IsEmpty}");
            Console.ReadKey();

        }
    }
}
