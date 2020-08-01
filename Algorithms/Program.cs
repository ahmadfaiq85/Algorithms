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
            Node first = new Node() { Value = 5 };
            Node second = new Node() { Value = 1 };

            first.Next = second;

            Node third = new Node() { Value = 3 };
            second.Next = third;

            PrintLinkedList(first);
        }

        private static void PrintLinkedList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
