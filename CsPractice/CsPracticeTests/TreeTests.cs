using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures;
using CsPractice.DataStructures.Trees;

namespace CsPracticeTests
{
    [TestClass]
    public class TreeTests
    {
        #region BinaryTree tests

        [TestMethod]
        public void TestBinaryTreeInOrderTraversal()
        {            
            BinaryTree<int> tree = GenerateBinaryTree();

            ArrayList<int> list = tree.InOrderTraversal();

            Assert.AreEqual(3, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(1, list[3]);
            Assert.AreEqual(6, list[4]);
            Assert.AreEqual(5, list[5]);
        }

        [TestMethod]
        public void TestBinaryTreePreOrderTraversal()
        {
            BinaryTree<int> tree = GenerateBinaryTree();

            ArrayList<int> list = tree.PreOrderTraversal();

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(3, list[2]);
            Assert.AreEqual(4, list[3]);
            Assert.AreEqual(5, list[4]);
            Assert.AreEqual(6, list[5]);
        }

        [TestMethod]
        public void TestBinaryTreePostOrderTraversal()
        {
            BinaryTree<int> tree = GenerateBinaryTree();

            ArrayList<int> list = tree.PostOrderTraversal();

            Assert.AreEqual(3, list[0]);
            Assert.AreEqual(4, list[1]);
            Assert.AreEqual(2, list[2]);
            Assert.AreEqual(6, list[3]);
            Assert.AreEqual(5, list[4]);
            Assert.AreEqual(1, list[5]);
        }

        #endregion

        #region BinarySearchTreeTests

        [TestMethod]
        public void TestBinarySearchTreeInOrderTraversal()
        {
            BinarySearchTree<int> tree = GenerateBinarySearchTree();

            ArrayList<int> list = tree.InOrderTraversal();

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(5, list[3]);
            Assert.AreEqual(7, list[4]);
            Assert.AreEqual(10, list[5]);
            Assert.AreEqual(12, list[6]);
        }

        [TestMethod]
        public void TestBinarySearchTreePreOrderTraversal()
        {
            BinarySearchTree<int> tree = GenerateBinarySearchTree();

            ArrayList<int> list = tree.PreOrderTraversal();

            Assert.AreEqual(5, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(1, list[2]);
            Assert.AreEqual(4, list[3]);
            Assert.AreEqual(7, list[4]);
            Assert.AreEqual(10, list[5]);
            Assert.AreEqual(12, list[6]);
        }

        [TestMethod]
        public void TestBinarySearchTreePostOrderTraversal()
        {
            BinarySearchTree<int> tree = GenerateBinarySearchTree();

            ArrayList<int> list = tree.PostOrderTraversal();

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(4, list[1]);
            Assert.AreEqual(2, list[2]);
            Assert.AreEqual(12, list[3]);
            Assert.AreEqual(10, list[4]);
            Assert.AreEqual(7, list[5]);
            Assert.AreEqual(5, list[6]);
        }

        [TestMethod]
        public void TestBinarySearchTreeAlreadyExistsException()
        {
            BinarySearchTree<int> tree = GenerateBinarySearchTree();
            Assert.ThrowsException<AlreadyExistsException>(() => tree.Add(4));
        }

        [TestMethod]
        public void TestBinarySearchTreeNotFoundException()
        {
            BinarySearchTree<int> tree = GenerateBinarySearchTree();
            Assert.ThrowsException<NotFoundException>(() => tree.Get(11));
        }

        #endregion

        #region BinaryMinHeapTests

        [TestMethod]
        public void TestBinaryMinHeapGeneration()
        {
            BinaryMinHeap<int> heap = GenerateBinaryMinHeap();

            ArrayList<int> list = heap.InOrderTraversal();

            Assert.AreEqual(7, list[0]);
            Assert.AreEqual(4, list[1]);
            Assert.AreEqual(10, list[2]);
            Assert.AreEqual(1, list[3]);
            Assert.AreEqual(5, list[4]);
            Assert.AreEqual(2, list[5]);
            Assert.AreEqual(12, list[6]);
        }

        [TestMethod]
        public void TestBinaryMinHeapAdd()
        {
            BinaryMinHeap<int> heap = GenerateBinaryMinHeap();

            heap.Add(3);

            ArrayList<int> list = heap.InOrderTraversal();

            Assert.AreEqual(7, list[0]);
            Assert.AreEqual(4, list[1]);
            Assert.AreEqual(3, list[2]);
            Assert.AreEqual(10, list[3]);
            Assert.AreEqual(1, list[4]);
            Assert.AreEqual(5, list[5]);
            Assert.AreEqual(2, list[6]);
            Assert.AreEqual(12, list[7]);
        }

        [TestMethod]
        public void TestBinaryMinHeapExtract()
        {
            BinaryMinHeap<int> heap = GenerateBinaryMinHeap();

            int item = heap.TakeMin();

            ArrayList<int> list = heap.InOrderTraversal();

            Assert.AreEqual(1, item);
            Assert.AreEqual(7, list[0]);
            Assert.AreEqual(4, list[1]);
            Assert.AreEqual(10, list[2]);
            Assert.AreEqual(2, list[3]);
            Assert.AreEqual(12, list[4]);
            Assert.AreEqual(5, list[5]);
        }

        [TestMethod]
        public void TestBinaryMinHeapExtractAll()
        {
            BinaryMinHeap<int> heap = GenerateBinaryMinHeap();

            ArrayList<int> list = new ArrayList<int>();
            
            while (heap.Root != null)
            {
                list.Append(heap.TakeMin());
            }

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(5, list[3]);
            Assert.AreEqual(7, list[4]);
            Assert.AreEqual(10, list[5]);
            Assert.AreEqual(12, list[6]);
        }

        #endregion

        #region Helpers

        private BinaryTree<int> GenerateBinaryTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>(1);

            BinaryTreeNode<int> node1 = tree.Root;
            BinaryTreeNode<int> node2 = new BinaryTreeNode<int>(2);
            node1.Left = node2;
            BinaryTreeNode<int> node3 = new BinaryTreeNode<int>(3);
            node2.Left = node3;
            BinaryTreeNode<int> node4 = new BinaryTreeNode<int>(4);
            node2.Right = node4;
            BinaryTreeNode<int> node5 = new BinaryTreeNode<int>(5);
            node1.Right = node5;
            BinaryTreeNode<int> node6 = new BinaryTreeNode<int>(6);
            node5.Left = node6;

            return tree;
        }

        private BinarySearchTree<int> GenerateBinarySearchTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);

            tree.Add(7);
            tree.Add(2);
            tree.Add(4);
            tree.Add(10);
            tree.Add(1);
            tree.Add(12);

            return tree;
        }

        private BinaryMinHeap<int> GenerateBinaryMinHeap()
        {
            BinaryMinHeap<int> heap = new BinaryMinHeap<int>(5);

            heap.Add(7);
            heap.Add(2);
            heap.Add(4);
            heap.Add(10);
            heap.Add(1);
            heap.Add(12);

            return heap;
        }

        #endregion
    }
}
