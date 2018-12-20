using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsPractice.Problems.ArraysAndStrings;

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

        #region StringPermutationChecker

        [TestMethod]
        public void PositivePermutationCheckerTest()
        {
            StringPermutationChecker checker = new StringPermutationChecker();
            string a = "abcdefghijklmnopqrstuvwkyzabcdefghijklmnopqrstuvwkyz";
            string b = "abghijkvwktuvwkyyzabcdefghijklmlcdefmnopqrstunopqrsz"; // Scrambled it up with copy/pastes

            bool result = checker.IsPermutation(a, b);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SmallPositivePermutationCheckerTest()
        {
            StringPermutationChecker checker = new StringPermutationChecker();
            string a = "$";
            string b = "$";

            bool result = checker.IsPermutation(a, b);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativePermutationCheckerTest()
        {
            StringPermutationChecker checker = new StringPermutationChecker();
            string a = "abcdefghijklmnopqrstuvwkyzabcdefghijklmnopqrstuvwkyz";
            string b = "zbghijkvwktuvwkyyzabcdefghijklmlcdefmnopqrstunopqrsz"; // Changed first a to z

            bool result = checker.IsPermutation(a, b);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SpecialNegativePermutationCheckerTest()
        {
            StringPermutationChecker checker = new StringPermutationChecker();
            string a = "abcdefghijklmnopqrstuvwkyzabcdefghijklmnopqrstuvwkyz";
            string b = "abghijkvwktuvwkyyzabcdefghijklmlcdefmnopqrstunopqrs";

            bool result = checker.IsPermutation(a, b);

            Assert.IsFalse(result);
        }

        #endregion

        #region URLifier

        [TestMethod]
        public void BasicURLifyTest()
        {
            URLifier mutator = new URLifier();
            char[] input = "Mr John Smith    ".ToCharArray();

            mutator.Urlify(input, 13);

            Assert.AreEqual("Mr%20John%20Smith", new string(input));
        }

        [TestMethod]
        public void LongURLifyTest()
        {
            URLifier mutator = new URLifier();
            char[] input = "Mr John Smith and his wife Mrs Smith              ".ToCharArray();

            mutator.Urlify(input, 36);

            Assert.AreEqual("Mr%20John%20Smith%20and%20his%20wife%20Mrs%20Smith", new string(input));
        }

        [TestMethod]
        public void NoSpaceURLifyTest()
        {
            URLifier mutator = new URLifier();
            char[] input = "LongStringNoSpaces".ToCharArray();

            mutator.Urlify(input, 18);

            Assert.AreEqual("LongStringNoSpaces", new string(input));
        }

        [TestMethod]
        public void EmptyStringURLifyTest()
        {
            URLifier mutator = new URLifier();
            char[] input = "".ToCharArray();

            mutator.Urlify(input, 0);

            Assert.AreEqual("", new string(input));
        }

        #endregion
    }
}
