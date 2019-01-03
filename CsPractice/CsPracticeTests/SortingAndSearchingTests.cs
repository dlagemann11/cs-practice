using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Problems.SortingAndSearching;

namespace CsPracticeTests
{
    [TestClass]
    public class SortingAndSearchingTests
    {
        #region SortedArrayMerger

        [TestMethod]
        public void BasicSortedArrayMergeTest()
        {
            SortedArrayMerger merger = new SortedArrayMerger();
            int[] A = new int[10];
            A[0] = 1;
            A[1] = 3;
            A[2] = 5;
            A[3] = 7;
            A[4] = 9;
            A[5] = 11;
            int[] B = new int[4];
            B[0] = 2;
            B[1] = 6;
            B[2] = 7;
            B[3] = 10;

            merger.MergeSortedArrays(A, B);

            Assert.IsTrue(TestUtilities.IsSorted(A));
            Assert.AreEqual(11, A[9]);
        }

        [TestMethod]
        public void AllBBiggerThanASortedArrayMergeTest()
        {
            SortedArrayMerger merger = new SortedArrayMerger();
            int[] A = new int[10];
            A[0] = 1;
            A[1] = 3;
            A[2] = 5;
            A[3] = 7;
            A[4] = 9;
            A[5] = 11;
            int[] B = new int[4];
            B[0] = 12;
            B[1] = 13;
            B[2] = 15;
            B[3] = 17;

            merger.MergeSortedArrays(A, B);

            Assert.IsTrue(TestUtilities.IsSorted(A));
            Assert.AreEqual(17, A[9]);
        }

        [TestMethod]
        public void AllABiggerThanBSortedArrayMergeTest()
        {
            SortedArrayMerger merger = new SortedArrayMerger();
            int[] A = new int[10];
            A[0] = 11;
            A[1] = 13;
            A[2] = 15;
            A[3] = 17;
            A[4] = 19;
            A[5] = 21;
            int[] B = new int[4];
            B[0] = 3;
            B[1] = 4;
            B[2] = 8;
            B[3] = 10;

            merger.MergeSortedArrays(A, B);

            Assert.IsTrue(TestUtilities.IsSorted(A));
            Assert.AreEqual(21, A[9]);
        }

        #endregion

        #region AnagramSorter

        [TestMethod]
        public void BasicAnagramSortTest()
        {
            AnagramSorter sorter = new AnagramSorter();
            string[] array = new string[]
            {
                "iceman",
                "cattaco",
                "cinema",
                "blue",
                "eel",
                "tacocat",
                "lee",
                "manice"
            };

            sorter.AnagramSort(array);

            Assert.AreEqual("iceman", array[0]);
            Assert.AreEqual("cinema", array[1]);
            Assert.AreEqual("manice", array[2]);
            Assert.AreEqual("blue", array[3]);
            Assert.AreEqual("eel", array[4]);
            Assert.AreEqual("lee", array[5]);
            Assert.AreEqual("tacocat", array[6]);
            Assert.AreEqual("cattaco", array[7]);
        }

        #endregion

        #region RotatedArraySearcher

        [TestMethod]
        public void LeftOverInflectionRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 15, 16, 19, 20, 25, 1, 3, 4, 5, 6, 10, 14 };

            int result = searcher.Search(array, 16);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NormalRightRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 15, 16, 19, 20, 25, 1, 3, 4, 5, 6, 10, 14 };

            int result = searcher.Search(array, 10);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void RightOverInflectionRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 6, 10, 14, 15, 16, 19, 20, 25, 1, 3, 4, 5 };

            int result = searcher.Search(array, 5);

            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void NormalLeftRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 6, 10, 14, 15, 16, 19, 20, 25, 1, 3, 4, 5 };

            int result = searcher.Search(array, 6);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LeftRepeatsLeftSearchRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 10, 1, 1, 2, 3, 5, 7, 9 };

            int result = searcher.Search(array, 1);

            Assert.IsTrue(result == 1 || result == 2);
        }

        [TestMethod]
        public void LeftRepeatsRightSearchRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 10, 10, 10, 10, 3, 5, 7, 9 };

            int result = searcher.Search(array, 3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RightRepeatsRightSearchRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 10, 1, 2, 3, 3, 3, 3, 4 };

            int result = searcher.Search(array, 4);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void RightRepeatsLeftSearchRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 10, 1, 2, 3, 3, 3, 3, 3 };

            int result = searcher.Search(array, 1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RepeatsAroundRotatedArraySearcherTest()
        {
            RotatedArraySearcher searcher = new RotatedArraySearcher();
            int[] array = { 3, 5, 7, 1, 3, 3, 3, 3, 3 };

            int result = searcher.Search(array, 1);

            Assert.AreEqual(3, result);
        }

        #endregion
    }
}
