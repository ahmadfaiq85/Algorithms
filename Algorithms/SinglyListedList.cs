using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SinglyListedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            //Save current head
            Node<T> temp = Head;

            Head = node;

            //Shift former head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
                Head = node;
            else
                Tail.Next = node;

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next;

            if (Count == 1)
                Tail = null;

            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                //find secondlast node
                var secondLastNode = Head;
                while (secondLastNode.Next != Tail)
                {
                    secondLastNode = secondLastNode.Next;
                }

                secondLastNode.Next = null;
                Tail = secondLastNode;
            }

        }

        public bool IsEmpty => Count == 0;
    }
}
