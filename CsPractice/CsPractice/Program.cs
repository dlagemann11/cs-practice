using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsPractice.DataStructures.Trees;

namespace CsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running this will test the Trie using the entire english dictionary.");
            Trie englishTrie = new Trie();

            Console.WriteLine("Loading dictionary...");
            DateTime start = DateTime.Now;
            string[] theEnglishLanguage = File.ReadAllLines("Resources/words_alpha.txt");
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            Console.WriteLine("Dictionary loaded. Time elapsed: " + duration.TotalSeconds.ToString("F3") + " seconds.");
            Console.WriteLine();
            Console.WriteLine("Loading Trie...");
            start = DateTime.Now;
            foreach (string word in theEnglishLanguage)
            {
                englishTrie.AddWord(word);
            }
            end = DateTime.Now;
            duration = end - start;
            Console.WriteLine("Trie loaded. Time elapsed: " + duration.TotalSeconds.ToString("F3") + " seconds.");
            Console.WriteLine();
            MainMenu(englishTrie);
        }

        private static void MainMenu(Trie trie)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("1) Check for word");
                Console.WriteLine("2) Check for prefix");
                Console.WriteLine("q) Quit");
                Console.Write("> ");
                var key = Console.ReadKey().KeyChar;


                switch (key)
                {
                    case '1':
                        CheckWord(trie);
                        break;
                    case '2':
                        CheckPrefix(trie);
                        break;
                    case 'q':
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }

        private static void CheckWord(Trie trie)
        {
            Console.WriteLine();
            Console.Write("Input word: ");
            string input = Console.ReadLine();
            Console.WriteLine("Word exists: " + trie.HasWord(input));
            Console.WriteLine();
        }

        private static void CheckPrefix(Trie trie)
        {
            Console.WriteLine();
            Console.Write("Input prefix: ");
            string input = Console.ReadLine();
            Console.WriteLine("Prefix exists: " + trie.HasPrefix(input));
            Console.WriteLine();
        }
    }
}
