using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures.Trees;

namespace CsPracticeTests
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void TestAddCaseInsensitiveWordToTrie()
        {
            Trie trie = new Trie();

            trie.AddWord("Awesome");

            Assert.IsTrue(trie.HasWord("awesome"));
        }

        [TestMethod]
        public void TestAddOverlappingWordsToTrie()
        {
            Trie trie = new Trie();

            trie.AddWord("a");
            trie.AddWord("an");
            trie.AddWord("and");

            Assert.IsTrue(trie.HasWord("a"));
            Assert.IsTrue(trie.HasWord("an"));
            Assert.IsTrue(trie.HasWord("and"));
        }

        [TestMethod]
        public void TestGetPrefixFromTrie()
        {
            Trie trie = new Trie();

            trie.AddWord("awesome");

            Assert.IsTrue(trie.HasPrefix("awes"));
        }

        [TestMethod]
        public void TestZeroLengthWord()
        {
            Trie trie = new Trie();

            Assert.ThrowsException<ArgumentException>(() => trie.AddWord(""));
        }

        [TestMethod]
        public void TestNonAlphaWord()
        {
            Trie trie = new Trie();

            Assert.ThrowsException<ArgumentException>(() => trie.AddWord("Awful!"));
        }
    }
}
