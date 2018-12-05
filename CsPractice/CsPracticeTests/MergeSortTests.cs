using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Algorithms;

namespace CsPracticeTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void TestSmallArray()
        {
            MergeSorter<int> sorter = new MergeSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(30, 0, 100);

            sorter.MergeSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }

        [TestMethod]
        public void TestLargeArray()
        {
            MergeSorter<int> sorter = new MergeSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(100000);

            sorter.MergeSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }

        [TestMethod]
        public void TestTinyArray()
        {
            MergeSorter<int> sorter = new MergeSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(4);

            sorter.MergeSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            MergeSorter<int> sorter = new MergeSorter<int>();
            int[] array = TestUtilities.GenerateIntArray(0);

            sorter.MergeSort(array);

            Assert.IsTrue(TestUtilities.IsSorted(array));
        }
    }
}
