using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    //class DoublyLinkedList
    // {

    public class DoublyLinkedList<T> :

        System.Collections.Generic.ICollection<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }



        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }
        public void AddFirst(LinkedListNode<T> node)
        {
            //save off the head node so we don't lose it
            LinkedListNode<T> temp = Head;
            //Point head to the new node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;
            //Count++;

            if (Count == 0)
            {
                //if the list was empty then Head and Tail should
                //both point to the new node.
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;

        }
        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            node.Previous = Tail;
        }
        Tail = node;
        Count++;
}






    public void RemoveFirst()
    {
        if (Count != 0)
        {
            Head = Head.Next;
            Count--;

            if (Count == 0)
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
        if (Count != 0)
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
            Count--;
        }

    }
    public int Count
    {
        get;
        private set;
    }
    public void Add(T item)
    {
        AddFirst(item);
    }

    public bool Contains(T item)
    {
        LinkedListNode<T> current = Head;
        while (current != null)
        {
            if (current.Value.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        LinkedListNode<T> current = Head;
        while (current != null)
        {
            array[arrayIndex++] = current.Value;
            current = current.Next;
        }
    }

    public bool IsReadOnly
    {
        get
        {
            return false;
        }
    }


    public bool Remove(T item)
    {
        LinkedListNode<T> previous = null;
        LinkedListNode<T> current = Head;

        while (current != null)
        {
            if (current.Value.Equals(item))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                    else
                    {
                        current.Next.Previous = previous;
                    }
                    Count--;
                }
                else
                {
                    RemoveFirst();
                }
                return true;
            }
            previous = current;
            current = current.Next;
        }
        return false;
    }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
    {
        LinkedListNode<T> current = Head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }
    System.Collections.IEnumerable System.Collections.IEnumerable.GetEnumerator()
    {
        return ((System.Collections.Gerenic.IEnumberable<T>)this).GetEnumerator();
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
}

