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

        #region PalindromPermutationChecker

        [TestMethod]
        public void OddPalindromPermutationTest()
        {
            PalindromePermutationChecker checker = new PalindromePermutationChecker();

            bool result = checker.IsPalindromePermutation("Tact Coa");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EvenPalindromPermutationTest()
        {
            PalindromePermutationChecker checker = new PalindromePermutationChecker();

            bool result = checker.IsPalindromePermutation("Never even or odd");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExtraCharsPalindromPermutationTest()
        {
            PalindromePermutationChecker checker = new PalindromePermutationChecker();

            bool result = checker.IsPalindromePermutation("A man, Panama, a plan, a canal –");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmptyPalindromPermutationTest()
        {
            PalindromePermutationChecker checker = new PalindromePermutationChecker();

            bool result = checker.IsPalindromePermutation("");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativeOddPalindromPermutationTest()
        {
            PalindromePermutationChecker checker = new PalindromePermutationChecker();

            bool result = checker.IsPalindromePermutation("TacoTa");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NegativeEvenPalindromPermutationTest()
        {
            PalindromePermutationChecker checker = new PalindromePermutationChecker();

            bool result = checker.IsPalindromePermutation("Neven odd or even");

            Assert.IsFalse(result);
        }

        #endregion

        #region OneAwayChecker

        [TestMethod]
        public void PositiveReplaceOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pale", "bale");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PositiveRemoveMiddleOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pale", "ple");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PositiveRemoveEndOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pale", "pal");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PositiveInsertMiddleOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pae", "pale");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PositiveInsertEndOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pale", "pales");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NegativeReplaceTwoOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pale", "bake");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NegativeInsertTwoOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("ThereAreToDiferences", "ThereAreTwoDifferences");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NegativeInsertAndReplaceOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("ThereAreTooDiferences", "ThereAreTwoDifferences");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmptyInputOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("", "");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AlreadySameOneAwayTest()
        {
            OneAwayChecker checker = new OneAwayChecker();

            bool result = checker.IsOneAway("pale", "pale");

            Assert.IsTrue(result);
        }

        #endregion

        #region StringCompressor

        [TestMethod]
        public void BasicStringCompressorTest()
        {
            StringCompressor compressor = new StringCompressor();

            string result = compressor.Compress("aabcccccaaa");

            Assert.AreEqual("a2b1c5a3", result);
        }

        [TestMethod]
        public void LongStringCompressorTest()
        {
            StringCompressor compressor = new StringCompressor();

            string result = compressor.Compress("aabbbbccdddddeefgggggghijjjjjjjjjkkkllllMMMMMnnnnnnoooooooppqqqrrrrsssssttttttuvwwwwxxxxyyZZZZZZZZZZ");

            Assert.AreEqual("a2b4c2d5e2f1g6h1i1j9k3l4M5n6o7p2q3r4s5t6u1v1w4x4y2Z10", result);
        }

        [TestMethod]
        public void LastSingleStringCompressorTest()
        {
            StringCompressor compressor = new StringCompressor();

            string result = compressor.Compress("aabcccccaaaf");

            Assert.AreEqual("a2b1c5a3f1", result);
        }

        [TestMethod]
        public void NoCompressCompressorTest()
        {
            StringCompressor compressor = new StringCompressor();

            string result = compressor.Compress("aBcDeffggghiJkl");

            Assert.AreEqual("aBcDeffggghiJkl", result);
        }

        [TestMethod]
        public void EmptyStringCompressorTest()
        {
            StringCompressor compressor = new StringCompressor();

            string result = compressor.Compress("");

            Assert.AreEqual("", result);
        }

        #endregion

        #region MatrixRotater

        [TestMethod]
        public void BasicMatrixRotaterTest()
        {
            MatrixRotater rotater = new MatrixRotater();
            int[,] matrix = GenerateSquareMatrix(4);

            int[,] result = rotater.Rotate(matrix);

            Assert.AreEqual(12, result[0, 0]);
            Assert.AreEqual(8, result[0, 1]);
            Assert.AreEqual(4, result[0, 2]);
            Assert.AreEqual(0, result[0, 3]);
            Assert.AreEqual(13, result[1, 0]);
            Assert.AreEqual(9, result[1, 1]);
            Assert.AreEqual(5, result[1, 2]);
            Assert.AreEqual(1, result[1, 3]);
            Assert.AreEqual(14, result[2, 0]);
            Assert.AreEqual(10, result[2, 1]);
            Assert.AreEqual(6, result[2, 2]);
            Assert.AreEqual(2, result[2, 3]);
            Assert.AreEqual(15, result[3, 0]);
            Assert.AreEqual(11, result[3, 1]);
            Assert.AreEqual(7, result[3, 2]);
            Assert.AreEqual(3, result[3, 3]);
        }

        [TestMethod]
        public void BasicInPlaceMatrixRotaterTest()
        {
            MatrixRotater rotater = new MatrixRotater();
            int[,] matrix = GenerateSquareMatrix(4);

            rotater.RotateInPlace(matrix);

            Assert.AreEqual(12, matrix[0, 0]);
            Assert.AreEqual(8, matrix[0, 1]);
            Assert.AreEqual(4, matrix[0, 2]);
            Assert.AreEqual(0, matrix[0, 3]);
            Assert.AreEqual(13, matrix[1, 0]);
            Assert.AreEqual(9, matrix[1, 1]);
            Assert.AreEqual(5, matrix[1, 2]);
            Assert.AreEqual(1, matrix[1, 3]);
            Assert.AreEqual(14, matrix[2, 0]);
            Assert.AreEqual(10, matrix[2, 1]);
            Assert.AreEqual(6, matrix[2, 2]);
            Assert.AreEqual(2, matrix[2, 3]);
            Assert.AreEqual(15, matrix[3, 0]);
            Assert.AreEqual(11, matrix[3, 1]);
            Assert.AreEqual(7, matrix[3, 2]);
            Assert.AreEqual(3, matrix[3, 3]);
        }

        private int[,] GenerateSquareMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            int n = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = n;
                    n++;
                }
            }

            return matrix;
        }

        #endregion

        #region MatrixZeroer

        [TestMethod]
        public void BasicMatrixZeroerTest()
        {
            MatrixZeroer zeroer = new MatrixZeroer();
            int[,] matrix = new int[4, 3];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;
            matrix[1, 0] = 10;
            matrix[1, 1] = 11;
            matrix[1, 2] = 12;
            matrix[2, 0] = 20;
            matrix[2, 1] = 21;
            matrix[2, 2] = 22;
            matrix[3, 0] = 30;
            matrix[3, 1] = 31;
            matrix[3, 2] = 0;

            zeroer.Zero(matrix);

            Assert.AreEqual(0, matrix[0, 0]);
            Assert.AreEqual(0, matrix[0, 1]);
            Assert.AreEqual(0, matrix[0, 2]);
            Assert.AreEqual(0, matrix[1, 0]);
            Assert.AreEqual(11, matrix[1, 1]);
            Assert.AreEqual(0, matrix[1, 2]);
            Assert.AreEqual(0, matrix[2, 0]);
            Assert.AreEqual(21, matrix[2, 1]);
            Assert.AreEqual(0, matrix[2, 2]);
            Assert.AreEqual(0, matrix[3, 0]);
            Assert.AreEqual(0, matrix[3, 1]);
            Assert.AreEqual(0, matrix[3, 2]);
        }

        #endregion
    }
}
