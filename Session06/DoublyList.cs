using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    class DoubleList<T>
    {
        Node<T> head; 

        internal Node<T> Head { get => head; set => head = value; }

        public DoubleList() { Head = null; }

        
        public bool IsEmpty() { return Head == null; }

        
        public int GetLenth()
        {
        
            if (IsEmpty()) { return 0; }
        
            if (Head.Next == null) { return 1; }
          
            Node<T> c = Head;
            int i = 1;
            while (c.Next != null)
            {
                c = c.Next;
                ++i;
            }
            return i;
        }

        public void Append(T value)
        {
            Node<T> item = new Node<T>(value);

            
            if (IsEmpty()) { Head = item; return; }

           
            if (Head.Next == null)
            {
                Head.Next = item;
                item.Pre = Head;
                return;
            }

           
            Node<T> c = Head;
            while (c.Next != null) { c = c.Next; }
            c.Next = item;
            item.Pre = c;
        }

       
        public void Insert(T value, int i)
        {
            
            if (GetLenth() < i)
            {
                Console.WriteLine("not correct place");
                return;
            }

            Node<T> c = new Node<T>(value);

           
            if (i == 1)
            {
                Head.Next.Pre = c;  
                c.Next = Head.Next; 
                c.Pre = Head;   
                Head.Next = c;  
                return;
            }

            int j = 1;
            Node<T> cur = Head;
            while (cur.Next != null && i > j)
            {
                cur = cur.Next;
                ++j;
            }
            if (j == i)
            {
                cur.Next.Pre = c;   
                c.Next = cur.Next; 
                c.Pre = cur;    
                cur.Next = c;  
            }
            else
            {
                Console.WriteLine("not correct place");
            }
        }

        
        public void Delete(int i)
        {
            if (GetLenth() < i)
            {
                Console.WriteLine("not correct place");
                return;
            }

            
            if (i == 1)
            {
                Head = Head.Next;
                Head.Pre = null;
                return;
            }

            
            Node<T> c = Head;
            int j = 1;
            while (c.Next != null && j < i)
            {
                c = c.Next;
                ++j;
            }
            if (j == i)
            {
                
                if (c.Next == null)
                {
                    c.Pre.Next = null;
                    c.Pre = null;
                }
                else
                {
                    c.Next.Pre = c.Pre;
                    c.Pre.Next = c.Next;
                }
            }
            else
            {
                Console.WriteLine("not correct place");
            }
        }

       
        public T GetElem(int i)
        {
            if (GetLenth() < i)
            {
                Console.WriteLine("not correct place");
                return default(T);
            }

            if (i == 1)
            {
                return Head.Data;
            }

            Node<T> c = Head;
            int j = 1;
            while (c.Next != null && j < i)
            {
                c = c.Next;
                ++j;
            }
            if (i == j)
            {
                return c.Data;
            }
            else
            {
                Console.WriteLine("not correct place");
                return default(T);
            }
        }

        
        
        public int GetPos(T data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("null");
                return -1;
            }

            if (Head.Data.Equals(data))
            {
                return 1;
            }

            Node<T> c = Head;
            int i = 1;
            int length = GetLenth();
            while (c != null && !c.Data.Equals(data) && i <= length)
            {
                c = c.Next;
                ++i;
            }
            if (i <= length)
                return i;
            else
                return -1;
        }
    }
}