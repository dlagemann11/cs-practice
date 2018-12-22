using System;
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
