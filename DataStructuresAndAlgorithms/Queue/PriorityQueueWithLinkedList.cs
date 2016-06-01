using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class PriorityQueueWithLinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T item)
        {
            if (list.Count == 0)
            {
                list.AddLast(item);
            }
            else
            {
                var current = list.First;
                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    list.AddLast(item);
                }
                else
                {
                    list.AddBefore(current, item);
                }
            }
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
