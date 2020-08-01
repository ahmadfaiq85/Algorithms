using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateNodes();
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
