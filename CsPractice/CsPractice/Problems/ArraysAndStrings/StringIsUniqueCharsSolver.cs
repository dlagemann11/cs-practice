using System.Collections.Generic;

namespace CsPractice.Problems.ArraysAndStrings
{
    public class StringIsUniqueCharsSolver
    {
        public bool HashTableSolve(string s)
        {
            Dictionary<char, bool> table = new Dictionary<char, bool>();
            for (int i = 0; i < s.Length; i++)
            {
                if (table.ContainsKey(s[i]))
                {
                    return false;
                }
                else
                {
                    table.Add(s[i], true);
                }
            }
            return true;
        }

        public bool BitVectorSolve(string s)
        {
            bool[] vector = new bool[256];
            for (int i = 0; i < s.Length; i++)
            {
                if (vector[s[i]])
                {
                    return false;
                }
                else
                {
                    vector[s[i]] = true;
                }
            }
            return true;
        }

        public bool IterativeSolve(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
