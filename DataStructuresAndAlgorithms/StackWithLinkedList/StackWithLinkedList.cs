using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackWithLinkedList<T> : IEnumerable<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T value = list.First.Value;
            list.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return list.First.Value;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Clear()
        {
            list.Clear();
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
