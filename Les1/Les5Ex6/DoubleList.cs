using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex6
{
    public class DoubleList<T>
    {
        public DoubleList(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoubleList<T> Previous { get; set; }
        public DoubleList<T> Next { get; set; }
    }
}
