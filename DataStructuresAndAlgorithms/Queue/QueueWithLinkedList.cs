using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueWithLinkedList<T> : IEnumerable<T>
    {
        LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T Dequeue()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
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
