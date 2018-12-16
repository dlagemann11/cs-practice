using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Algorithms;
using CsPractice.Problems;

namespace CsPracticeTests
{
    [TestClass]
    public class BitManipulationTests
    {
        #region Utility function tests

        [TestMethod]
        public void GetBitTest()
        {
            BitManipulator manipulator = new BitManipulator();
            int number = 13; // 1101
            bool[] results = new bool[4];

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = manipulator.GetBit(number, i);
            }

            Assert.IsTrue(results[0]);
            Assert.IsFalse(results[1]);
            Assert.IsTrue(results[2]);
            Assert.IsTrue(results[3]);
        }

        [TestMethod]
        public void SetBitTest()
        {
            BitManipulator manipulator = new BitManipulator();
            int number = 8; // 1000
            int[] results = new int[4];

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = manipulator.SetBit(number, i);
            }

            Assert.AreEqual(9, results[0]);
            Assert.AreEqual(10, results[1]);
            Assert.AreEqual(12, results[2]);
            Assert.AreEqual(8, results[3]);
        }

        [TestMethod]
        public void ClearBitTest()
        {
            BitManipulator manipulator = new BitManipulator();
            int number = 11; // 1011
            int[] results = new int[4];

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = manipulator.ClearBit(number, i);
            }

            Assert.AreEqual(10, results[0]);
            Assert.AreEqual(9, results[1]);
            Assert.AreEqual(11, results[2]);
            Assert.AreEqual(3, results[3]);
        }

        [TestMethod]
        public void UpdateBitTest()
        {
            BitManipulator manipulator = new BitManipulator();
            int number = 9; // 1001
            int[] results = new int[4];

            results[0] = manipulator.UpdateBit(number, 1, true); // 1011
            results[1] = manipulator.UpdateBit(number, 2, true); // 1101
            results[2] = manipulator.UpdateBit(number, 3, false); // 0001
            results[3] = manipulator.UpdateBit(number, 0, true); // 1001

            Assert.AreEqual(11, results[0]);
            Assert.AreEqual(13, results[1]);
            Assert.AreEqual(1, results[2]);
            Assert.AreEqual(9, results[3]);
        }

        #endregion

        #region BitInsertion test

        [TestMethod]
        public void BasicBitInsertionTest()
        {
            BitInserter inserter = new BitInserter();
            int insertionTarget = 65; // 1000001
            int insertion = 3; // 11

            int result = inserter.Insert(insertionTarget, insertion, 2, 3); // Expected: 1001101

            Assert.AreEqual(77, result);
        }

        [TestMethod]
        public void OverwriteBitInsertionTest()
        {
            BitInserter inserter = new BitInserter();
            int insertionTarget = 77; // 1001101
            int insertion = 9; // 1001

            int result = inserter.Insert(insertionTarget, insertion, 1, 4); // Expected: 1010011

            Assert.AreEqual(83, result);
        }

        [TestMethod]
        public void SingleBitInsertionTest()
        {
            BitInserter inserter = new BitInserter();
            int insertionTarget = 65; // 1000001
            int insertion = 1;

            int result = inserter.Insert(insertionTarget, insertion, 5, 5); // Expected: 1100001

            Assert.AreEqual(97, result);
        }

        #endregion
    }
}
