using NUnit.Framework;

namespace Algorithms.Tests
{
    public class DoublyLinkedListTests
    {
        DoublyLinkedList<int> _list; 

        [SetUp] 
        public void SetUp()
        {
            _list = new DoublyLinkedList<int>();
        }

        [Test]
        public void CreateEmptyList_CorrectState()
        {
            Assert.IsTrue(_list.IsEmpty);
            Assert.IsNull(_list.Head);
            Assert.IsNull(_list.Tail);

        }

        [Test]
        public void AddFirst_and_AddLast_OneItem_CorrectState()
        {
            _list.AddFirst(1);
            Assert.AreEqual(1, _list.Count);
            Assert.IsFalse(_list.IsEmpty);
            Assert.AreSame(_list.Head, _list.Tail);

            _list.AddLast(5);
            _list.AddFirst(2);
            
            Assert.AreEqual(3, _list.Count);
        }
    }
}
