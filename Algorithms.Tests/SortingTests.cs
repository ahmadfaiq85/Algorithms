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
        public void IsSorted()
        {
            int[] items = new int[5] { 6, 3, 8, 9, 1 };
            var sorting = new Algorithms.Sorting();

            sorting.BubbleSort(items);
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