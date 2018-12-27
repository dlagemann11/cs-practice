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
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        [TestMethod]
        public void BasicSlimDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 1, 9, 10, 1001, 9, 9, 9, 11, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeSlim(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        [TestMethod]
        public void AllDupesFastDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 5, 5, 5, 5, 5, 5 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeFast(head);

            int[] expectedData = new int[] { 5 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        [TestMethod]
        public void AllDupesSlimDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 5, 5, 5, 5, 5, 5 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeSlim(head);

            int[] expectedData = new int[] { 5 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        [TestMethod]
        public void NoDupesFastDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeFast(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        [TestMethod]
        public void NoDupesSlimDeDuperTest()
        {
            LinkedListDeduper deduper = new LinkedListDeduper();

            int[] data = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            SingleLinkNode<int> head = TestUtilities.GenerateSinglyLinkedList(data);

            deduper.DeDupeSlim(head);

            int[] expectedData = new int[] { 1, 5, 3, 9, 10, 1001, 11 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
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
        public void TestKthToLastFirstSuccess()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            int k = problem.KthToLast(10, head);

            Assert.AreEqual(1, k);
        }

        [TestMethod]
        public void TestKthToLastLastSuccess()
        {
            KthToLastLinkedList problem = new KthToLastLinkedList();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            int k = problem.KthToLast(1, head);

            Assert.AreEqual(10, k);
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

        #endregion

        #region MiddleNodeDelete

        [TestMethod]
        public void BasicMiddleNodeDeleteTest()
        {
            MiddleNodeDeleter deleter = new MiddleNodeDeleter();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            deleter.Delete(head.Next.Next.Next.Next);

            int[] expectedData = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        [TestMethod]
        public void LastMiddleNodeDeleteTest()
        {
            MiddleNodeDeleter deleter = new MiddleNodeDeleter();
            SingleLinkNode<int> head = GenerateSimpleLinkedList();

            deleter.Delete(head.Next.Next.Next.Next.Next.Next.Next.Next);

            int[] expectedData = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(head, expectedData));
        }

        #endregion

        #region Reverser

        [TestMethod]
        public void BasicLinkedListReverserTest()
        {
            LinkedListReverser reverser = new LinkedListReverser();

            SingleLinkNode<int> result = reverser.Reverse(GenerateSimpleLinkedList());

            int[] expected = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(result, expected));
        }

        [TestMethod]
        public void OneMemberLinkedListReverserTest()
        {
            LinkedListReverser reverser = new LinkedListReverser();

            SingleLinkNode<int> input = new SingleLinkNode<int>(5);
            SingleLinkNode<int> result = reverser.Reverse(input);

            int[] expected = new int[] { 5 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList(result, expected));
        }

        #endregion

        #region LoopDetector



        #endregion

        private SingleLinkNode<int> GenerateSimpleLinkedList()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return TestUtilities.GenerateSinglyLinkedList(data);
        }
    }
}
