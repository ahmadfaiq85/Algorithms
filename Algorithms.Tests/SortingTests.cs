using NUnit.Framework;

namespace Algorithms.Tests
{
    public class SortingTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IsSorted_UsingBubbleSort()
        {
            int[] items = new int[5] { 6, 3, 8, 9, 1 };
            var sorting = new Sorting();

            sorting.BubbleSort(items);
            Print(items);
            CollectionAssert.IsOrdered(items);
        }

        [Test]
        public void IsSorted_SelectionSort()
        {
            int[] items = new int[6] { 6, 3, -2, 8, 9, 1 };
            var sorting = new Sorting();

            sorting.SelectionSort(items);
            Print(items);

            CollectionAssert.IsOrdered(items);
        }

        [Test]
        public void IsSorted_InsertionSort()
        {
            int[] items = new int[4] { 6, 8, -2, 3 };
            var sorting = new Sorting();

            sorting.InsertionSort(items);
            Print(items);

            CollectionAssert.IsOrdered(items);
        }

        private void Print(int[] array)
        {
            TestContext.WriteLine("-----    Test Output    -----");

            foreach (int item in array)
            {
                TestContext.Write(item + " ");
            }

            TestContext.WriteLine("-----------------------------");
        }
    }
}