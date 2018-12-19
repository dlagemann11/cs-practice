using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsPractice.Problems;

namespace CsPracticeTests
{
    [TestClass]
    public class ArraysAndStringsTests
    {
        #region StringIsUniqueCharsSolver

        [TestMethod]
        public void PositiveHashTableTest()
        {
            StringIsUniqueCharsSolver solver = new StringIsUniqueCharsSolver();

            bool result = solver.HashTableSolve("aghvuly198&@(b");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativeHashTableTest()
        {
            StringIsUniqueCharsSolver solver = new StringIsUniqueCharsSolver();

            bool result = solver.HashTableSolve("kyqaxh3%&8`1,><;&");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PositiveBitVectorTest()
        {
            StringIsUniqueCharsSolver solver = new StringIsUniqueCharsSolver();

            bool result = solver.BitVectorSolve("aghvuly198&@(b");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativeBitVectorTest()
        {
            StringIsUniqueCharsSolver solver = new StringIsUniqueCharsSolver();

            bool result = solver.BitVectorSolve("kyqaxh3%&8`1,><;&");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PositiveIterativeTest()
        {
            StringIsUniqueCharsSolver solver = new StringIsUniqueCharsSolver();

            bool result = solver.IterativeSolve("aghvuly198&@(b");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativeIterativeTest()
        {
            StringIsUniqueCharsSolver solver = new StringIsUniqueCharsSolver();

            bool result = solver.IterativeSolve("kyqaxh3%&8`1,><;&");

            Assert.IsFalse(result);
        }

        #endregion
    }
}
