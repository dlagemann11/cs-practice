using System.Collections.Generic;

namespace CsPractice.Problems.Medium
{
    public class BookSearcher
    {
        private string[] book;
        private Dictionary<string, int> wordTable;

        public BookSearcher(string[] bookToSearch)
        {
            book = bookToSearch;
        }

        public BookSearcher(string[] bookToSearch, bool buildTable)
        {
            book = bookToSearch;
            if (buildTable)
            {
                BuildWordTable(book);
            }
        }

        public int GreedyFindOccurrences(string word)
        {
            int count = 0;
            foreach (string thisWord in book)
            {
                if (thisWord == word)
                {
                    count++;
                }
            }
            return count;
        }

        public int TableFindOccurrences(string word)
        {
            return wordTable[word];
        }

        private void BuildWordTable(string[] words)
        {
            wordTable = new Dictionary<string, int>();
            foreach (string thisWord in words)
            {
                if (wordTable.ContainsKey(thisWord))
                {
                    wordTable[thisWord]++;
                }
                else
                {
                    wordTable.Add(thisWord, 1);
                }
            }
        }
    }
}
