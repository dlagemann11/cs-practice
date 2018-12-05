using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures.Trees
{
    public class TrieNode
    {
        public const char TERMINATOR = '*';
        private const int TERMINATING_INDEX = 26;
        private const int ASCII_ALPHA_START = 97;
        private const int ASCII_ALPHA_END = 122;

        private TrieNode[] children;

        public char Letter { get; }

        public TrieNode()
        {
            // This should only be the root node
            Letter = (char)0;
            children = new TrieNode[27];
        }

        public TrieNode(char letter)
        {
            Letter = letter;
            if (letter != TERMINATOR)
            {
                children = new TrieNode[27];
            }
        }

        public TrieNode AddLetter(char letter)
        {
            int index = ConvertCharToIndex(letter);
            if (children[index] == null)
            {
                children[index] = new TrieNode(letter);
            }
            return children[index];
        }

        public TrieNode AddTerminator()
        {
            return AddLetter(TERMINATOR);
        }

        public bool HasChild(char letter)
        {
            int index = ConvertCharToIndex(letter);
            return (children[index] != null);
        }

        public TrieNode GoToChild(char letter)
        {
            int index = ConvertCharToIndex(letter);
            return (children[index]);
        }

        private int ConvertCharToIndex(char letter)
        {
            if (letter == TERMINATOR)
            {
                return TERMINATING_INDEX;
            }
            if (letter >= ASCII_ALPHA_START && letter <= ASCII_ALPHA_END)
            {
                return letter - ASCII_ALPHA_START;
            }

            throw new ArgumentException("Only lower-case alphabetical characters and the " + TERMINATOR + " can be stored in the Trie.");
        }
    }
}
