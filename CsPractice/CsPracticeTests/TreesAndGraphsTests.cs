using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures;
using CsPractice.DataStructures.Trees;
using CsPractice.Problems.TreesAndGraphs;

namespace CsPracticeTests
{
    [TestClass]
    public class TreesAndGraphsTests
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
    }
}
