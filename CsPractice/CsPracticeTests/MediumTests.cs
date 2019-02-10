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
    }
}
