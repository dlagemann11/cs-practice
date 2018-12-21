using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures;
using CsPractice.Problems.LinkedLists;

namespace CsPracticeTests
{
    [TestClass]
    public class LinkedListTests
    {
        #region LinkedListDeduper

        [TestMethod]
        public void BasicFastDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 1, 9, 10, 1001, 9, 9, 9, 11, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeFast(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(CheckLinkedList(head, expectedData));
        }

        [TestMethod]
        public void BasicSlimDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 1, 9, 10, 1001, 9, 9, 9, 11, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeSlim(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(CheckLinkedList(head, expectedData));
        }

        [TestMethod]
        public void AllDupesFastDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 5, 5, 5, 5, 5, 5 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeFast(head);

            int[] expectedData = new int[] { 5 };
            Assert.IsTrue(CheckLinkedList(head, expectedData));
        }

        [TestMethod]
        public void AllDupesSlimDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 5, 5, 5, 5, 5, 5 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeSlim(head);

            int[] expectedData = new int[] { 5 };
            Assert.IsTrue(CheckLinkedList(head, expectedData));
        }

        [TestMethod]
        public void NoDupesFastDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeFast(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(CheckLinkedList(head, expectedData));
        }

        [TestMethod]
        public void NoDupesSlimDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeSlim(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(CheckLinkedList(head, expectedData));
        }

        private bool CheckLinkedList<T>(SingleLinkNode<T> head, T[] expectedData) where T : IComparable
        {
            SingleLinkNode<T> thisNode = head;
            for (int i = 0; i < expectedData.Length; i++)
            {
                if (thisNode.Data.CompareTo(expectedData[i]) != 0)
                {
                    return false;
                }
                thisNode = thisNode.Next;
            }
            return true;
        }

        #endregion

        #region KthToLast

        [TestMethod]
        public void TestKthToLastSuccess()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            int k = problem.KthToLast(3, head);

            Assert.AreEqual(8, k);
        }

        [TestMethod]
        public void TestKthToLastSuccess2()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            int k = problem.KthToLast(6, head);

            Assert.AreEqual(5, k);
        }

        [TestMethod]
        public void TestKthToLastKTooSmall()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            Assert.ThrowsException<ArgumentException>(() => problem.KthToLast(0, head));
        }

        [TestMethod]
        public void TestKthToLastKTooLarge()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            Assert.ThrowsException<ArgumentException>(() => problem.KthToLast(11, head));
        }

        private SingleLinkNode<int> GenerateSimpleLinkedList()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return TestUtilities.GenerateSinglyLinkedList(data);
        }

        #endregion
    }
}
