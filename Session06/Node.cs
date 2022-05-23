using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    class Node<T>
    {
        T data; //数据域
        Node<T> next;   //后继节点
        Node<T> pre;    //前驱节点

        internal Node<T> Next { get => next; set => next = value; }
        internal Node<T> Pre { get => pre; set => pre = value; }
        public T Data { get => data; set => data = value; }

        //构造器
        public Node(T value, Node<T> next, Node<T> pre)
        {
            Data = value;
            Next = next;
            Pre = pre;
        }

        //构造器
        public Node(T value)
        {
            Data = value;
        }

        //构造器
        public Node(Node<T> next, Node<T> pre)
        {
            Next = next;
            Pre = pre;
        }

        //构造器
        public Node(Node<T> next)
        {
            Next = next;
        }

        //构造器
        public Node()
        {
            Data = default(T);
            Next = null;
            Pre = null;
        }
    }
}