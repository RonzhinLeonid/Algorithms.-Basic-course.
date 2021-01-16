using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex5
{
    public class QueueList<T>
    {
        public QueueList(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public QueueList<T> Next { get; set; }
    }
}
