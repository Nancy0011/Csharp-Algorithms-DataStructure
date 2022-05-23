using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value)
        {
            value = value;
        }
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }

    }
}
