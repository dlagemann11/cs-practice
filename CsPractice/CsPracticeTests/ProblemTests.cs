using System;
using System.Collections;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures;
using CsPractice.DataStructures.Trees;
using CsPractice.Problems;

namespace CsPracticeTests
{
    [TestClass]
    public class ProblemTests
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

        #region ThreeStacksFromArray

        [TestMethod]
        public void ThreeStacksFromArraySuccess()
        {
            ThreeStacksFromArray<string> stacks = GenerateThreeStacksFromArray();

            string pop1 = stacks.PopFirst();
            string pop2 = stacks.PopSecond();
            string pop3 = stacks.PopThird();
            string pop4 = stacks.PopThird();
            string pop5 = stacks.PopThird();
            string pop6 = stacks.PopThird();
            string pop7 = stacks.PopSecond();
            string pop8 = stacks.PopFirst();
            string pop9 = stacks.PopSecond();
            string pop10 = stacks.PopFirst();
            string pop11 = stacks.PopFirst();
            string pop12 = stacks.PopSecond();

            Assert.AreEqual("Stack1String4", pop1);
            Assert.AreEqual("Stack2String4", pop2);
            Assert.AreEqual("Stack3String4", pop3);
            Assert.AreEqual("Stack3String3", pop4);
            Assert.AreEqual("Stack3String2", pop5);
            Assert.AreEqual("Stack3String1", pop6);
            Assert.AreEqual("Stack2String3", pop7);
            Assert.AreEqual("Stack1String3", pop8);
            Assert.AreEqual("Stack2String2", pop9);
            Assert.AreEqual("Stack1String2", pop10);
            Assert.AreEqual("Stack1String1", pop11);
            Assert.AreEqual("Stack2String1", pop12);
        }


        private ThreeStacksFromArray<string> GenerateThreeStacksFromArray()
        {
            ThreeStacksFromArray<string> stacks = new ThreeStacksFromArray<string>();

            stacks.PushFirst("Stack1String1");
            stacks.PushFirst("Stack1String2");
            stacks.PushFirst("Stack1String3");
            stacks.PushFirst("Stack1String4");
            stacks.PushSecond("Stack2String1");
            stacks.PushThird("Stack3String1");
            stacks.PushSecond("Stack2String2");
            stacks.PushThird("Stack3String2");
            stacks.PushSecond("Stack2String3");
            stacks.PushThird("Stack3String3");
            stacks.PushSecond("Stack2String4");
            stacks.PushThird("Stack3String4");

            return stacks;
        }

        #endregion

        #region BstFromSortedArray

        [TestMethod]
        public void TestBstFromSortedArrayMedium()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            BstFromSortedArray problem = new BstFromSortedArray();

            BinarySearchTree<int> tree = problem.CreateBinarySearchTree(array);
            ArrayList<int> traversal = tree.InOrderTraversal();

            Assert.AreEqual(10, traversal.Count);
            Assert.AreEqual(0, traversal[0]);
            Assert.AreEqual(1, traversal[1]);
            Assert.AreEqual(2, traversal[2]);
            Assert.AreEqual(3, traversal[3]);
            Assert.AreEqual(4, traversal[4]);
            Assert.AreEqual(5, traversal[5]);
            Assert.AreEqual(6, traversal[6]);
            Assert.AreEqual(7, traversal[7]);
            Assert.AreEqual(8, traversal[8]);
            Assert.AreEqual(9, traversal[9]);
        }

        [TestMethod]
        public void TestBstFromSortedArrayTiny()
        {
            int[] array = new int[] { 3 };
            BstFromSortedArray problem = new BstFromSortedArray();

            BinarySearchTree<int> tree = problem.CreateBinarySearchTree(array);
            ArrayList<int> traversal = tree.InOrderTraversal();

            Assert.AreEqual(1, traversal.Count);
            Assert.AreEqual(3, traversal[0]);
        }

        #endregion

        #region BitInsertion

        [TestMethod]
        public void TestBitInsertion()
        {
            BitInsertion inserter = new BitInsertion();
            BitArray N = new BitArray(11);
            BitArray M = new BitArray(5);
            N[0] = true;
            M[0] = true;
            M[3] = true;
            M[4] = true;

            BitArray result = inserter.Insert(N, M, 2, 6);

            Assert.AreEqual(true, result[0]);
            Assert.AreEqual(false, result[1]);
            Assert.AreEqual(false, result[2]);
            Assert.AreEqual(false, result[3]);
            Assert.AreEqual(true, result[4]);
            Assert.AreEqual(false, result[5]);
            Assert.AreEqual(false, result[6]);
            Assert.AreEqual(true, result[7]);
            Assert.AreEqual(true, result[8]);
            Assert.AreEqual(false, result[9]);
            Assert.AreEqual(false, result[10]);
        }

        #endregion

        #region BookSearcher

        [TestMethod]
        public void GreedyBookSearchSingleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book);

            int occurrences = searcher.GreedyFindOccurrences("Beowulf");

            Assert.AreEqual(268, occurrences);
        }

        [TestMethod]
        public void GreedyBookSearchMultipleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book);

            int occurrences1 = searcher.GreedyFindOccurrences("Beowulf");
            int occurrences2 = searcher.GreedyFindOccurrences("sword");
            int occurrences3 = searcher.GreedyFindOccurrences("Grendel");
            int occurrences4 = searcher.GreedyFindOccurrences("hero");
            int occurrences5 = searcher.GreedyFindOccurrences("Hrothgar");

            Assert.AreEqual(268, occurrences1);
            Assert.AreEqual(84, occurrences2);
            Assert.AreEqual(112, occurrences3);
            Assert.AreEqual(85, occurrences4);
            Assert.AreEqual(135, occurrences5);
        }

        [TestMethod]
        public void TableBookSearchSingleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book, true);

            int occurrences = searcher.TableFindOccurrences("Beowulf");

            Assert.AreEqual(268, occurrences);
        }

        [TestMethod]
        public void TableBookSearchMultipleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book, true);

            int occurrences1 = searcher.TableFindOccurrences("Beowulf");
            int occurrences2 = searcher.TableFindOccurrences("sword");
            int occurrences3 = searcher.TableFindOccurrences("Grendel");
            int occurrences4 = searcher.TableFindOccurrences("hero");
            int occurrences5 = searcher.TableFindOccurrences("Hrothgar");

            Assert.AreEqual(268, occurrences1);
            Assert.AreEqual(84, occurrences2);
            Assert.AreEqual(112, occurrences3);
            Assert.AreEqual(85, occurrences4);
            Assert.AreEqual(135, occurrences5);
        }

        private string[] GetBook()
        {
            string textBlob = File.ReadAllText("Resources/Beowulf.txt");
            char[] separators = { ',', '.', '!', '?', ';', ':', '\'', '\"', '-', '_', '+', '=', '~', '[', ']', '{', '}', '(', ')', '<', '>', ' ', (char)9, (char)10, (char)13 };
            string[] book = textBlob.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return book;
        }

        #endregion

        
    }
}
