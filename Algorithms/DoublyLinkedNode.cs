using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class DoublyLinkedNode<T>
    {
        public DoublyLinkedNode<T> Next { get; set; }
        public DoublyLinkedNode<T> Previous { get; set; }

        public T Value { get; set; }

        public DoublyLinkedNode(T value)
        {
            Value = value;
        }


    }
}
