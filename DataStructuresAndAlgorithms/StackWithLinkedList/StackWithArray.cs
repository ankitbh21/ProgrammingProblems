using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackWithArray<T> : IEnumerable<T>
    {
        int size = 0;

        T[] items = new T[0];

        public void Push(T item)
        {
            if (size == items.Length)
            {
                int newLength = size == 0 ? 4 : size * 2;
                T[] newArray = new T[newLength];
                items.CopyTo(newArray, 0);
                items = newArray;
            }

            items[size] = item;
            size++;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            size--;
            return items[size];
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[size - 1];
        }

        public int Count
        {
            get { return size; }
        }

        public void Clear()
        {
            size = 0;
            // TODO : Clear array
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size-1; i >= 0; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
