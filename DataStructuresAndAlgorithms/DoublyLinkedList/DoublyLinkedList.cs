using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class LinkedList<T> : ICollection<T>, IEnumerable<LinkedListNode<T>>
    {
        public bool IsEmpty { get { return Count == 0; } }

        public LinkedListNode<T> Head { get; private set; }

        public LinkedListNode<T> Tail { get; private set; }

        #region Add
        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> oldHead = Head;
            Head = node;
            Head.Next = oldHead;
            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                Tail.Previous = Head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }
        #endregion

        #region Remove
        public void RemoveFirst()
        {
            if (!IsEmpty)
            {
                Count--;
                Head = Head.Next;
                if (IsEmpty)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }                
            }
        }

        public void RemoveLast()
        {
            if (!IsEmpty)
            {
                Count--;
                Tail = Tail.Previous;
                if (IsEmpty)
                {
                    Head = null;
                }
                else
                {
                    Tail.Next = null;
                }                
            }
        }
        #endregion

        #region ICollection
        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> node = Head;
            while (node != null)
            {
                if (node.Value.Equals(item))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> node = Head;
            while (node != null)
            {
                array[arrayIndex++] = node.Value;
                node = node.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> node = Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (current.Next == null)
                    {
                        RemoveLast();
                    }
                    else if (current.Previous == null)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        Count--;
                    }
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
        #endregion

        IEnumerator<LinkedListNode<T>> IEnumerable<LinkedListNode<T>>.GetEnumerator()
        {
            return ((IEnumerable<LinkedListNode<T>>)this).GetEnumerator();
        }
    }
}
