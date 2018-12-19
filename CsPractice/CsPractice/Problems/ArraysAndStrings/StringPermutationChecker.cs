using System.Collections.Generic;

namespace CsPractice.Problems.ArraysAndStrings
{
    public class StringPermutationChecker
    {
        public bool IsPermutation(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            Dictionary<char, int> aChars = ToDict(a);
            Dictionary<char, int> bChars = ToDict(b);
            foreach (char thisChar in aChars.Keys)
            {
                if (aChars[thisChar] != bChars[thisChar])
                {
                    return false;
                }
            }
            return true;
        }

        private Dictionary<char, int> ToDict(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char thisChar in s)
            {
                if (dict.ContainsKey(thisChar))
                {
                    dict[thisChar]++;
                }
                else
                {
                    dict.Add(thisChar, 1);
                }
            }
            return dict;
        }
    }
}
