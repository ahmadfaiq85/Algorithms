using NUnit.Framework;
using System;
using System.Globalization;

namespace Algorithms.Tests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new ArrayStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void PushTwoItems_Pop_ReturnsCorrectLastItem()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peak());
        }

        [Test]
        public void PushTwoItems_Peak_ReturnsCorrectLastItem()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            int num = stack.Peak();

            Assert.AreEqual(2, num);
        }

        [Test]
        public void PushTwoItemsAndPop_PopOne_ReturnsHeadElement()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peak());
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new ArrayStack<int>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                stack.Pop();
            });
        }
    }
}
