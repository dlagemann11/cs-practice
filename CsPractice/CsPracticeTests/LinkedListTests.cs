using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures;
using CsPractice.Problems.LinkedLists;

namespace CsPracticeTests
{
    [TestClass]
    public class LinkedListTests
    {
        #region KthToLast

        [TestMethod]
        public void TestKthToLastSuccess()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSinglyLinkedList();

            int k = problem.KthToLast(3, head);

            Assert.AreEqual(8, k);
        }

        [TestMethod]
        public void TestKthToLastSuccess2()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSinglyLinkedList();

            int k = problem.KthToLast(6, head);

            Assert.AreEqual(5, k);
        }

        [TestMethod]
        public void TestKthToLastKTooSmall()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSinglyLinkedList();

            Assert.ThrowsException<ArgumentException>(() => problem.KthToLast(0, head));
        }

        [TestMethod]
        public void TestKthToLastKTooLarge()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSinglyLinkedList();

            Assert.ThrowsException<ArgumentException>(() => problem.KthToLast(11, head));
        }

        private SingleLinkNode<int> GenerateSinglyLinkedList()
        {
            SingleLinkNode<int> head = new SingleLinkNode<int>(1);
            SingleLinkNode<int> node = head;
            for (int i = 2; i < 11; i++)
            {
                node.Next = new SingleLinkNode<int>(i);
                node = node.Next;
            }

            return head;
        }

        #endregion
    }
}
