using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex5
{
    class Queue<T> : IEnumerable<T>
    {
        QueueList<T> head; // головной элемент
        QueueList<T> tail; // хвостовой элемент
        int count;  // количество элементов в списке
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            QueueList<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        /// <summary>
        /// Добавление элемента в очердь
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            QueueList<T> node = new QueueList<T>(data);
            QueueList<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }
        /// <summary>
        /// Удаление элемента в очердь
        /// </summary>
        /// <param name="data"></param>
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }
        /// <summary>
        /// Кол-во элементов в очереди
        /// </summary>
        public int Count { get { return count; } }
        /// <summary>
        /// Проверяет путой список или нет
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }

        /// <summary>
        /// Первый элемент очереди
        /// </summary>
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        /// <summary>
        /// Послдений элемент очереди
        /// </summary>
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }
        /// <summary>
        /// Очистка очереди
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        /// <summary>
        /// Проверка принадлежности очереди
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Contains(T data)
        {
            QueueList<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
    }
}
