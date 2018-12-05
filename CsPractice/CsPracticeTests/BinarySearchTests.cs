using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Algorithms;

namespace CsPracticeTests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void TestBasicLeftBinarySearch()
        {
            int[] array = GenerateSmallArray();
            BinarySearcher searcher = new BinarySearcher(array);

            bool found = searcher.BinarySearch(15);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestBasicRightBinarySearch()
        {
            int[] array = GenerateSmallArray();
            BinarySearcher searcher = new BinarySearcher(array);

            bool found = searcher.BinarySearch(102);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestFarLeftBinarySearch()
        {
            int[] array = GenerateSmallArray();
            BinarySearcher searcher = new BinarySearcher(array);

            bool found = searcher.BinarySearch(0);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestFarRightBinarySearch()
        {
            int[] array = GenerateSmallArray();
            BinarySearcher searcher = new BinarySearcher(array);

            bool found = searcher.BinarySearch(147);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestLargeArrayBinarySearch()
        {
            int[] array = TestUtilities.GenerateIntArray(100000);
            QuickSorter<int> sorter = new QuickSorter<int>();
            sorter.QuickSort(array);
            BinarySearcher searcher = new BinarySearcher(array);
                        
            bool found = searcher.BinarySearch(array[89127]);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestNotFoundInMiddleBinarySearch()
        {
            int[] array = GenerateSmallArray();
            BinarySearcher searcher = new BinarySearcher(array);

            bool found = searcher.BinarySearch(139);

            Assert.IsFalse(found);
        }

        [TestMethod]
        public void TestNotFoundOutsideOfRangeBinarySearch()
        {
            int[] array = GenerateSmallArray();
            BinarySearcher searcher = new BinarySearcher(array);

            bool found = searcher.BinarySearch(-3);

            Assert.IsFalse(found);
        }

        private int[] GenerateSmallArray()
        {
            int[] array = new int[50];            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 3;
            }
            return array;
        }
    }
}
