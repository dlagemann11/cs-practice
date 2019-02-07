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

        #region DepthLister

        [TestMethod]
        public void BasicDepthListerTest()
        {
            DepthLister depthLister = new DepthLister();
            BinaryTree<int> tree = GenerateBinaryTree();

            ArrayList<SingleLinkNode<int>> result = depthLister.BinaryTreeToLinkedLists(tree);

            int[] expected = new int[] { 1 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList<int>(result[0], expected));

            expected = new int[] { 3, 2 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList<int>(result[1], expected));

            expected = new int[] { 7, 6, 5, 4 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList<int>(result[2], expected));

            expected = new int[] { 15, 14, 13, 12, 11, 10, 9, 8 };
            Assert.IsTrue(TestUtilities.CheckSinglyLinkedList<int>(result[3], expected));

        }

        private BinaryTree<int> GenerateBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>(1);
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(7);
            BinaryTreeNode<int> node8 = new BinaryTreeNode<int>(8);
            BinaryTreeNode<int> node9 = new BinaryTreeNode<int>(9);
            BinaryTreeNode<int> node10 = new BinaryTreeNode<int>(10);
            BinaryTreeNode<int> node11 = new BinaryTreeNode<int>(11);
            BinaryTreeNode<int> node12 = new BinaryTreeNode<int>(12);
            BinaryTreeNode<int> node13 = new BinaryTreeNode<int>(13);
            BinaryTreeNode<int> node14 = new BinaryTreeNode<int>(14);
            BinaryTreeNode<int> node15 = new BinaryTreeNode<int>(15);

            tree.Root.Left = node2;
            tree.Root.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;
            node4.Left = node8;
            node4.Right = node9;
            node5.Left = node10;
            node5.Right = node11;
            node6.Left = node12;
            node6.Right = node13;
            node7.Left = node14;
            node7.Right = node15;

            return tree;
        }

        #endregion

        #region TreeBalanceDetector

        [TestMethod]
        public void BasicTreeBalanceDetectorTest()
        {
            TreeBalanceDetector<int> detector = new TreeBalanceDetector<int>();
            BinaryTree<int> tree = new BinaryTree<int>(1);
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(7);
            tree.Root.Left = node2;
            tree.Root.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Right = node7;
            node4.Left = node6;

            bool result = detector.IsBalanced(tree);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UnbalancedTreeBalanceDetectorTest()
        {
            TreeBalanceDetector<int> detector = new TreeBalanceDetector<int>();
            BinaryTree<int> tree = new BinaryTree<int>(1);
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(7);
            BinaryTreeNode<int> node8 = new BinaryTreeNode<int>(8);
            tree.Root.Left = node2;
            tree.Root.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Right = node7;
            node4.Left = node6;
            node7.Left = node8;

            bool result = detector.IsBalanced(tree);

            Assert.IsFalse(result);
        }

        #endregion

        #region BstValidater

        [TestMethod]
        public void BasicBstValidaterTest()
        {
            BstValidater validater = new BstValidater();
            BinaryTree<int> tree = new BinaryTree<int>(4);
            BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(1);
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(7);
            tree.Root.Left = node2;
            tree.Root.Right = node6;
            node2.Left = node1;
            node2.Right = node3;
            node6.Right = node7;
            node6.Left = node5;

            bool result = validater.Validate(tree.Root);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativeBstValidaterTest()
        {
            BstValidater validater = new BstValidater();
            BinaryTree<int> tree = new BinaryTree<int>(4);
            BinaryTreeNode<int> node1 = new BinaryTreeNode<int>(1);
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(0);
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> node7 = new BinaryTreeNode<int>(7);
            tree.Root.Left = node2;
            tree.Root.Right = node6;
            node2.Left = node1;
            node2.Right = node3;
            node6.Right = node7;
            node6.Left = node5;

            bool result = validater.Validate(tree.Root);

            Assert.IsFalse(result);
        }

        #endregion
    }
}
