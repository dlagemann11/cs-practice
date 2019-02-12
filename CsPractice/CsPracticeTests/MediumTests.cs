using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Problems.Medium;

namespace CsPracticeTests
{
    [TestClass]
    public class MediumTests
    {
        #region BookSearcher

        [TestMethod]
        public void GreedyBookSearchSingleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book);

            int occurrences = searcher.GreedyFindOccurrences("Beowulf");

            Assert.AreEqual(268, occurrences);
        }

        [TestMethod]
        public void GreedyBookSearchMultipleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book);

            int occurrences1 = searcher.GreedyFindOccurrences("Beowulf");
            int occurrences2 = searcher.GreedyFindOccurrences("sword");
            int occurrences3 = searcher.GreedyFindOccurrences("Grendel");
            int occurrences4 = searcher.GreedyFindOccurrences("hero");
            int occurrences5 = searcher.GreedyFindOccurrences("Hrothgar");

            Assert.AreEqual(268, occurrences1);
            Assert.AreEqual(84, occurrences2);
            Assert.AreEqual(112, occurrences3);
            Assert.AreEqual(85, occurrences4);
            Assert.AreEqual(135, occurrences5);
        }

        [TestMethod]
        public void TableBookSearchSingleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book, true);

            int occurrences = searcher.TableFindOccurrences("Beowulf");

            Assert.AreEqual(268, occurrences);
        }

        [TestMethod]
        public void TableBookSearchMultipleTest()
        {
            string[] book = GetBook();
            BookSearcher searcher = new BookSearcher(book, true);

            int occurrences1 = searcher.TableFindOccurrences("Beowulf");
            int occurrences2 = searcher.TableFindOccurrences("sword");
            int occurrences3 = searcher.TableFindOccurrences("Grendel");
            int occurrences4 = searcher.TableFindOccurrences("hero");
            int occurrences5 = searcher.TableFindOccurrences("Hrothgar");

            Assert.AreEqual(268, occurrences1);
            Assert.AreEqual(84, occurrences2);
            Assert.AreEqual(112, occurrences3);
            Assert.AreEqual(85, occurrences4);
            Assert.AreEqual(135, occurrences5);
        }

        private string[] GetBook()
        {
            string textBlob = File.ReadAllText("Resources/Beowulf.txt");
            char[] separators = { ',', '.', '!', '?', ';', ':', '\'', '\"', '-', '_', '+', '=', '~', '[', ']', '{', '}', '(', ')', '<', '>', ' ', (char)9, (char)10, (char)13 };
            string[] book = textBlob.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return book;
        }

        #endregion

        #region InPlaceSwapper

        [TestMethod]
        public void BasicInPlaceSwapperTest()
        {
            InPlaceSwapper swapper = new InPlaceSwapper();
            int a = 7;
            int b = 11;

            swapper.Swap(ref a, ref b);

            Assert.AreEqual(11, a);
            Assert.AreEqual(7, b);
        }

        [TestMethod]
        public void ZeroInPlaceSwapperTest()
        {
            InPlaceSwapper swapper = new InPlaceSwapper();
            int a = 7;
            int b = 0;

            swapper.Swap(ref a, ref b);

            Assert.AreEqual(0, a);
            Assert.AreEqual(7, b);
        }

        #endregion

        #region TicTacToeEvaluator

        [TestMethod]
        public void FirstRowXWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.X;
            cells[0, 2] = Token.X;
            cells[1, 0] = Token.O;
            cells[1, 1] = Token.O;
            cells[1, 2] = Token.X;
            cells[2, 0] = Token.X;
            cells[2, 1] = Token.O;
            cells[2, 2] = Token.O;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.XWins, result);
        }

        [TestMethod]
        public void SecondRowOWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.O;
            cells[0, 2] = Token.X;
            cells[1, 0] = Token.O;
            cells[1, 1] = Token.O;
            cells[1, 2] = Token.O;
            cells[2, 0] = Token.X;
            cells[2, 1] = Token.X;
            cells[2, 2] = Token.None;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.OWins, result);
        }

        [TestMethod]
        public void ThirdRowXWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.None;
            cells[0, 1] = Token.None;
            cells[0, 2] = Token.None;
            cells[1, 0] = Token.None;
            cells[1, 1] = Token.O;
            cells[1, 2] = Token.O;
            cells[2, 0] = Token.X;
            cells[2, 1] = Token.X;
            cells[2, 2] = Token.X;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.XWins, result);
        }

        [TestMethod]
        public void FirstColumnOWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.O;
            cells[0, 1] = Token.X;
            cells[0, 2] = Token.None;
            cells[1, 0] = Token.O;
            cells[1, 1] = Token.O;
            cells[1, 2] = Token.X;
            cells[2, 0] = Token.O;
            cells[2, 1] = Token.X;
            cells[2, 2] = Token.X;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.OWins, result);
        }

        [TestMethod]
        public void SecondColumnXWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.O;
            cells[0, 1] = Token.X;
            cells[0, 2] = Token.None;
            cells[1, 0] = Token.O;
            cells[1, 1] = Token.X;
            cells[1, 2] = Token.None;
            cells[2, 0] = Token.None;
            cells[2, 1] = Token.X;
            cells[2, 2] = Token.None;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.XWins, result);
        }

        [TestMethod]
        public void ThirdColumnOWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.X;
            cells[0, 2] = Token.O;
            cells[1, 0] = Token.X;
            cells[1, 1] = Token.X;
            cells[1, 2] = Token.O;
            cells[2, 0] = Token.O;
            cells[2, 1] = Token.None;
            cells[2, 2] = Token.O;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.OWins, result);
        }

        [TestMethod]
        public void FirstDiagonalXWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.O;
            cells[0, 2] = Token.None;
            cells[1, 0] = Token.O;
            cells[1, 1] = Token.X;
            cells[1, 2] = Token.O;
            cells[2, 0] = Token.O;
            cells[2, 1] = Token.None;
            cells[2, 2] = Token.X;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.XWins, result);
        }

        [TestMethod]
        public void SecondDiagonalOWinsTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.X;
            cells[0, 2] = Token.O;
            cells[1, 0] = Token.X;
            cells[1, 1] = Token.O;
            cells[1, 2] = Token.X;
            cells[2, 0] = Token.O;
            cells[2, 1] = Token.O;
            cells[2, 2] = Token.X;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.OWins, result);
        }

        [TestMethod]
        public void DrawTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.O;
            cells[0, 2] = Token.X;
            cells[1, 0] = Token.O;
            cells[1, 1] = Token.O;
            cells[1, 2] = Token.X;
            cells[2, 0] = Token.X;
            cells[2, 1] = Token.X;
            cells[2, 2] = Token.O;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.Draw, result);
        }

        [TestMethod]
        public void NoVictoryTicTacToeTest()
        {
            TicTacToeEvaluator evaluator = new TicTacToeEvaluator();
            Token[,] cells = new Token[3, 3];
            cells[0, 0] = Token.X;
            cells[0, 1] = Token.X;
            cells[0, 2] = Token.O;
            cells[1, 0] = Token.X;
            cells[1, 1] = Token.X;
            cells[1, 2] = Token.O;
            cells[2, 0] = Token.O;
            cells[2, 1] = Token.None;
            cells[2, 2] = Token.None;
            Board board = new Board() { Cells = cells };

            GameResult result = evaluator.HasWon(board);

            Assert.AreEqual(GameResult.NoVictory, result);
        }

        #endregion

        #region SmallestDiffer

        [TestMethod]
        public void BasicSmallestDiffTest()
        {
            SmallestDiffer differ = new SmallestDiffer();
            int[] a = new int[] { 1, 3, 15, 11, 2 };
            int[] b = new int[] { 23, 127, 235, 19, 8 };

            int result = differ.GetSmallestDiff(a, b);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AsymetricSmallestDiffTest()
        {
            SmallestDiffer differ = new SmallestDiffer();
            int[] a = new int[] { 7, 9, 1, 15, 6 };
            int[] b = new int[] { 18, 2 };

            int result = differ.GetSmallestDiff(a, b);

            Assert.AreEqual(1, result);
        }

        #endregion

        #region NoComparisonMaxxer

        [TestMethod]
        public void BasicNoComparisonMaxTest()
        {
            NoComparisonMaxxer maxxer = new NoComparisonMaxxer();

            int result = maxxer.Max(10, 7);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void NegativeNoComparisonMaxTest()
        {
            NoComparisonMaxxer maxxer = new NoComparisonMaxxer();

            int result = maxxer.Max(-10, 7);

            Assert.AreEqual(7, result);
        }

        #endregion
    }
}
