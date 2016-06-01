using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class QueueWithArray<T> : IEnumerable<T>
    {
        private int size = 0;

        private int head = 0;
        private int tail = -1;

        T[] list = new T[0];

        public void Enqueue(T item)
        {
            if (size == list.Length)
            {
                int newLength = size == 0 ? 4 : size * 2;
                T[] newList = new T[newLength];
                if (size > 0)
                {
                    int indexInNewList = 0;
                    if (tail < head)
                    {                        
                        for (int i = head; i < list.Length; i++)
                        {
                            newList[indexInNewList] = list[i];
                            indexInNewList++;
                        }
                        for (int i = 0; i <= tail; i++)
                        {
                            newList[indexInNewList] = list[i];
                            indexInNewList++;
                        }
                    }
                    else
                    {
                        for (int i = head; i <= tail; i++)
                        {
                            newList[indexInNewList] = list[i];
                            indexInNewList++;
                        }
                    }
                    
                    tail = indexInNewList - 1;
                }
                else
                {
                    tail = -1;
                }
                head = 0;
                list = newList;
            }

            if (tail == list.Length - 1)
            {
                tail = 0;
            }
            else
            {
                tail++;
            }

            list[tail] = item;          
            size++;
            
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = list[head];
            if (head == list.Length - 1)
            {
                head = 0;
            }
            else
            {
                head++;
            }
            size--;
            return item;

        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return list[head];
        }

        public int Count
        {
            get { return size; }
        }

        public void Clear()
        {
            size = 0;
            head = 0;
            tail = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (size > 0)
            {
                if (tail < head)
                {
                    for (int i = head; i < list.Length; i++)
                    {
                        yield return list[i];
                    }
                    for (int i = 0; i <= tail; i++)
                    {
                        yield return list[i];
                    }
                }
                else
                {
                    for (int i = head; i <= tail; i++)
                    {
                        yield return list[i];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
