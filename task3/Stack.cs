using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Stack<T>
    {
        List<T> list;
        public Stack()
        {
            list = new List<T>();
        }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }
    }
}
