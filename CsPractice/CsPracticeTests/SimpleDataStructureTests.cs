using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures;
using System.Text;

namespace CsPracticeTests
{
    [TestClass]
    public class SimpleDataStructureTests
    {
        // TODO: Need to refactor these into individual tests. Also more tests

        [TestMethod]
        public void StackTest()
        {
            Stack<int> stack = new Stack<int>();
            bool empty1 = stack.IsEmpty();
            stack.Push(3);
            stack.Push(2);
            stack.Push(9);
            stack.Push(5);
            stack.Push(8);
            bool empty2 = stack.IsEmpty();

            int item1 = stack.Pop();
            int item2 = stack.Pop();
            int item3 = stack.Peek();
            int item4 = stack.Pop();
            stack.Push(1);
            int item5 = stack.Pop();
            int item6 = stack.Pop();
            int item7 = stack.Pop();
            bool empty3 = stack.IsEmpty();

            Assert.AreEqual(8, item1);
            Assert.AreEqual(5, item2);
            Assert.AreEqual(9, item3);
            Assert.AreEqual(9, item4);
            Assert.AreEqual(1, item5);
            Assert.AreEqual(2, item6);
            Assert.AreEqual(3, item7);
            Assert.IsTrue(empty1);
            Assert.IsFalse(empty2);
            Assert.IsTrue(empty3);
        }

        [TestMethod]
        public void QueueTest()
        {
            Queue<string> queue = new Queue<string>();
            bool empty1 = queue.IsEmpty();
            queue.Enqueue("The");
            queue.Enqueue("quick");
            queue.Enqueue("brown");
            queue.Enqueue("fox");
            queue.Enqueue("DIED");
            bool empty2 = queue.IsEmpty();

            string item1 = queue.Dequeue();
            string item2 = queue.Dequeue();
            queue.Enqueue("quickly");
            string item3 = queue.Dequeue();
            string item4 = queue.Dequeue();
            string item5 = queue.Peek();
            string item6 = queue.Peek();
            string item7 = queue.Dequeue();
            string item8 = queue.Dequeue();
            bool empty3 = queue.IsEmpty();

            Assert.AreEqual("The", item1);
            Assert.AreEqual("quick", item2);
            Assert.AreEqual("brown", item3);
            Assert.AreEqual("fox", item4);
            Assert.AreEqual("DIED", item5);
            Assert.AreEqual("DIED", item6);
            Assert.AreEqual("DIED", item7);
            Assert.AreEqual("quickly", item8);
            Assert.IsTrue(empty1);
            Assert.IsFalse(empty2);
            Assert.IsTrue(empty3);
        }

        [TestMethod]
        public void SinglyLinkedListTest()
        {
            SingleLinkNode<int> headNode = new SingleLinkNode<int>(1);
            SingleLinkNode<int> nextNode = headNode.Add(2);
            nextNode = nextNode.Add(3);
            nextNode = nextNode.Add(4);
            nextNode = nextNode.Add(5);

            int node1 = headNode.Data;
            nextNode = headNode.Next;
            int node2 = nextNode.Data;
            nextNode = nextNode.Next;
            int node3 = nextNode.Data;
            nextNode = nextNode.Next;
            int node4 = nextNode.Data;
            nextNode = nextNode.Next;
            int node5 = nextNode.Data;
            nextNode = nextNode.Next;

            Assert.AreEqual(1, node1);
            Assert.AreEqual(2, node2);
            Assert.AreEqual(3, node3);
            Assert.AreEqual(4, node4);
            Assert.AreEqual(5, node5);
            Assert.IsNull(nextNode);
        }

        [TestMethod]
        public void DoublyLinkedListTest()
        {
            DoubleLinkNode<char> firstNode = new DoubleLinkNode<char>('c');
            DoubleLinkNode<char> nextNode = firstNode.AddLast('a');
            DoubleLinkNode<char> headNode = nextNode.AddLast('t');
            nextNode = firstNode.AddNext('o');
            nextNode = nextNode.AddNext('c');
            nextNode = nextNode.AddNext('a');
            DoubleLinkNode<char> tailNode = nextNode.AddNext('t');

            StringBuilder builder1 = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();

            nextNode = headNode;
            while (nextNode != null)
            {
                builder1.Append(nextNode.Data);
                nextNode = nextNode.Next;
            }
            string string1 = builder1.ToString();

            nextNode = tailNode;
            while (nextNode != null)
            {
                builder2.Append(nextNode.Data);
                nextNode = nextNode.Last;
            }
            string string2 = builder2.ToString();

            Assert.AreEqual("tacocat", string1);
            Assert.AreEqual(string1, string2);
        }

        [TestMethod]
        public void HashTableTest()
        {
            // TODO: Need tests for hash collisions
            HashTable<int, string> hashTable = new HashTable<int, string>();
            hashTable.Add(1, "foo");
            hashTable.Add(2, "fu");
            hashTable.Add(3, "fu you");
            hashTable.Add(4, "no you");
            hashTable.Add(5, "wtf");
            hashTable.Add(6, "fffffuuuuuu");

            string item1 = hashTable.Get(3);
            item1 = hashTable.Get(3);
            string item2 = hashTable.Get(5);
            item2 = hashTable.Get(5);
            string item3 = hashTable.Take(4);
            string item4 = hashTable.Take(2);
            hashTable.Delete(1);
            hashTable.Delete(6);

            Assert.AreEqual("fu you", item1);
            Assert.AreEqual("wtf", item2);
            Assert.AreEqual("no you", item3);
            Assert.AreEqual("fu", item4);
            Assert.ThrowsException<KeyNotFoundException>(() => hashTable.Get(4));
            Assert.ThrowsException<KeyNotFoundException>(() => hashTable.Get(2));
            Assert.ThrowsException<KeyNotFoundException>(() => hashTable.Get(1));
            Assert.ThrowsException<KeyNotFoundException>(() => hashTable.Get(6));
        }

        [TestMethod]
        public void ArrayListTest()
        {
            ArrayList<double> list = new ArrayList<double>();
            int count1 = list.Count;
            list.Append(8.8);
            list.Append(5.2);
            list.Append(12.865);
            int count2 = list.Count;
            list[1] = 0.6;
            list[3] = -2691;
            list.Append(0);
            int count3 = list.Count;

            Assert.AreEqual(8.8, list[0]);
            Assert.AreEqual(0.6, list[1]);
            Assert.AreEqual(12.865, list[2]);
            Assert.AreEqual(-2691, list[3]);
            Assert.AreEqual(0, list[4]);
            Assert.AreEqual(0, count1);
            Assert.AreEqual(3, count2);
            Assert.AreEqual(5, count3);
        }
    }
}
