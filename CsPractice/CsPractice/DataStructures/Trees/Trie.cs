using System;

namespace CsPractice.DataStructures.Trees
{
    public class Trie
    {
        private TrieNode root = new TrieNode();
        
        public void AddWord(string word)
        {
            ValidateWord(word);
            char[] chars = word.ToLower().ToCharArray();
            AddWordHelper(chars, 0, root);
        }

        public bool HasWord(string word)
        {
            ValidateWord(word);
            return HasPrefix(word + TrieNode.TERMINATOR);
        }

        public bool HasPrefix(string prefix)
        {
            ValidateWord(prefix);
            return WordSearchHelper(prefix.ToLower().ToCharArray(), 0, root);
        }

        private TrieNode AddWordHelper(char[] word, int index, TrieNode nodeToAddTo)
        {
            if (index < word.Length)
            {
                TrieNode newNode = nodeToAddTo.AddLetter(word[index]);
                index++;
                return AddWordHelper(word, index, newNode);
            }
            else
            {
                return nodeToAddTo.AddTerminator();
            }
        }

        private bool WordSearchHelper(char[] word, int index, TrieNode nodeToSearch)
        {
            if (index >= word.Length)
            {
                return true;
            }

            if (nodeToSearch.HasChild(word[index]))
            {
                nodeToSearch = nodeToSearch.GoToChild(word[index]);
                index++;
                return WordSearchHelper(word, index, nodeToSearch);
            }
            else
            {
                return false;
            }
        }

        private void ValidateWord(string word)
        {
            if (word.Length < 1)
            {
                throw new ArgumentException("Word must have at least one character");
            }
        }
    }
}
