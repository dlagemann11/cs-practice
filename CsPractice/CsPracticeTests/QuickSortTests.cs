using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Algorithms;

namespace CsPracticeTests
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void TestSmallArray()
        {
            QuickSorter<int> sorter = new QuickSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(30, 0, 100);

            sorter.QuickSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }

        [TestMethod]
        public void TestLargeArray()
        {
            QuickSorter<int> sorter = new QuickSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(100000);

            sorter.QuickSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }

        [TestMethod]
        public void TestTinyArray()
        {
            QuickSorter<int> sorter = new QuickSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(4);

            sorter.QuickSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            QuickSorter<int> sorter = new QuickSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(0);

            sorter.QuickSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }
    }
}
