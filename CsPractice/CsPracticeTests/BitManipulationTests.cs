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

        #region BitInsertion tests

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

        #region DoubleToBinaryStringConverter tests

        [TestMethod]
        public void BasicBinaryStringConverterTest()
        {
            DecimalToBinaryStringConverter converter = new DecimalToBinaryStringConverter();

            string result = converter.Convert(0.375d); // 0.25 + 0.125, or 1/4 + 1/8

            Assert.AreEqual("0.011", result);
        }

        [TestMethod]
        public void BigBinaryStringConverterTest()
        {
            DecimalToBinaryStringConverter converter = new DecimalToBinaryStringConverter();

            string result = converter.Convert(0.6416015625d); // 1/2^1 + 1/2^3 + 1/2^6 + 1/2^10

            Assert.AreEqual("0.1010010001", result);
        }

        [TestMethod]
        public void RangeBinaryStringConverterTest()
        {
            DecimalToBinaryStringConverter converter = new DecimalToBinaryStringConverter();

            string result1 = converter.Convert(1.1d);
            string result2 = converter.Convert(-0.1d);

            Assert.AreEqual("ERROR", result1);
            Assert.AreEqual("ERROR", result2);
        }

        [TestMethod]
        public void InvalidBinaryStringConverterTest()
        {
            DecimalToBinaryStringConverter converter = new DecimalToBinaryStringConverter();

            string result = converter.Convert(0.8d);

            Assert.AreEqual("ERROR", result);
        }

        #endregion

        #region BitFlipWinner tests

        [TestMethod]
        public void BasicBitFlipWinTest()
        {
            BitFlipWinner winner = new BitFlipWinner();

            int result = winner.Evaluate(1775); // 11011101111

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void RightZeroBitFlipWinTest()
        {
            BitFlipWinner winner = new BitFlipWinner();

            int result = winner.Evaluate(14); // 1110

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ManyZerosBitFlipWinTest()
        {
            BitFlipWinner winner = new BitFlipWinner();

            int result = winner.Evaluate(1025); // 10000000001

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ZeroBitFlipWinTest()
        {
            BitFlipWinner winner = new BitFlipWinner();

            int result = winner.Evaluate(0);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NegativeBitFlipWinTest()
        {
            BitFlipWinner winner = new BitFlipWinner();

            int result = winner.Evaluate(-8); // 1...1000

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void AllOnesBitFlipWinTest()
        {
            BitFlipWinner winner = new BitFlipWinner();

            int result = winner.Evaluate(-1);

            Assert.AreEqual(32, result);
        }

        #endregion

        #region NextAndPreviousWithSameOnes tests

        [TestMethod]
        public void BasicNextAndPreviousOnesTest()
        {
            NextAndPreviousWithSameOnesSolver solver = new NextAndPreviousWithSameOnesSolver();

            int[] result = solver.Solve(38);

            Assert.AreEqual(41, result[0]);
            Assert.AreEqual(37, result[1]);
        }

        [TestMethod]
        public void SmallNextAndPreviousOnesTest()
        {
            NextAndPreviousWithSameOnesSolver solver = new NextAndPreviousWithSameOnesSolver();

            int[] result = solver.Solve(8);

            Assert.AreEqual(16, result[0]);
            Assert.AreEqual(4, result[1]);
        }

        [TestMethod]
        public void ManyOnesNextAndPreviousOnesTest()
        {
            NextAndPreviousWithSameOnesSolver solver = new NextAndPreviousWithSameOnesSolver();

            int[] result = solver.Solve(15);

            Assert.AreEqual(23, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [TestMethod]
        public void InvalidNextAndPreviousOnesTest()
        {
            NextAndPreviousWithSameOnesSolver solver = new NextAndPreviousWithSameOnesSolver();

            int[] result = solver.Solve(0);

            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        #endregion
    }
}
