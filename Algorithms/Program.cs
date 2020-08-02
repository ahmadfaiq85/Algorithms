using Algorithms.Tests;
using System;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EnumerateStack();

            // CreateNodes();
        }

        public static void EnumerateStack()
        {
            var stack = new ArrayStack<int>();

            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void CreateNodes()
        {
            var first = new Node<int>(5);
            var second = new Node<int>(1);

            first.Next = second;

            var third = new Node<int>(3);
            second.Next = third;

            PrintLinkedList(first);
        }

        private static void PrintLinkedList(Node<int> node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
