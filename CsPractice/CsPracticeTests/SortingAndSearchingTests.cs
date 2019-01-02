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
    }
}
