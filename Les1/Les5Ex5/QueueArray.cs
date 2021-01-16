using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex5
{
    public class QueueArray
    {
        
        int[] array; // Массив с элементами
        int head; // головной элемент
        int tail; // головной элемент
        int count;  // количество элементов в списке

        /// <summary>
        /// Создаём очередь. Начальная ёмкость - 1;
        /// </summary>
        public QueueArray()
        {
            array = new int[1];
        }
        /// <summary>
        /// Кол-во элементов в очереди
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Очистка очереди
        /// </summary>
        public void Clear()
        {
            array = new int[4];
            head = 0;
            tail = 0;
            count = 0;
        }
        /// <summary>
        /// Добавление элемента в очередь.
        /// </summary>
        /// <param name="item">Добавляемый элемент.</param>
        public void Enqueue(int item)
        {
            if (Count == array.Length)
            {
                int capacity = array.Length * 2;
                SetCapacity(capacity);
            }
            array[tail] = item;
            tail = (tail + 1) % array.Length;
            count++;
        }

        /// <summary>
        /// Извлечение элемента из очереди.
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            int local = array[head];
            array[head] = 0;
            head = (head + 1) % array.Length;
            count--;
            return local;
        }

        /// <summary>
        /// Просмотр элемента на вершине очереди.
        /// </summary>
        /// <returns>Верхний элемент.</returns>
        public int Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return array[head];
        }
        /// <summary>
        /// Изменение ёмкости очереди
        /// </summary>
        /// <param name="capacity"></param>
        private void SetCapacity(int capacity)
        {
            int[] destinationArray = new int[capacity];
            if (Count > 0)
            {
                if (head < tail)
                    Array.Copy(array, head, destinationArray, 0, Count);
                else
                {
                    Array.Copy(array, head, destinationArray, 0, array.Length - head);
                    Array.Copy(array, 0, destinationArray, array.Length - head, tail);
                }
            }
            array = destinationArray;
            head = 0;
            if (Count == capacity)
                tail = 0;
            else
                tail = Count;
        }
        /// <summary>
        /// Проверяет путой список или нет
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }
    }
}
