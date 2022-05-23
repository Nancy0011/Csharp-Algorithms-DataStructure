﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    class LinkListNode
    {

        public class LinkedListNode<T>
        {
            public LinkedListNode(T value)
            {
                Value = value;

            }
            public T Value { get; set; }
            public LinkedListNode<T> Next { get; set; }
        }
    }




}

