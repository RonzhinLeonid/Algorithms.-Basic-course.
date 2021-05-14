using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Les5Ex6
{
    class DoubleQueue<T> : IEnumerable<T>
    {
        DoubleList<T> head; // головной элемент
        DoubleList<T> tail; // хвостовой элемент
        int count;  // количество элементов в списке

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleList<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        /// <summary>
        /// Добавление элемента в конец очерди
        /// </summary>
        /// <param name="data"></param>
        public void AddLast(T data)
        {
            DoubleList<T> node = new DoubleList<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        /// <summary>
        /// Добавление элемента в начало очереди
        /// </summary>
        /// <param name="data"></param>
        public void AddFirst(T data)
        {
            DoubleList<T> node = new DoubleList<T>(data);
            DoubleList<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        /// <summary>
        /// Удалении из начала очереди
        /// </summary>
        /// <returns></returns>
        public T DeleteFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }
        /// <summary>
        /// Удалении последнего элемента очереди
        /// </summary>
        /// <returns></returns>
        public T DeleteLast()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
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
            DoubleList<T> current = head;
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
