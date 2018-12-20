namespace CsPractice.Problems.ArraysAndStrings
{
    public class PalindromePermutationChecker
    {
        public bool IsPalindromePermutation(string input)
        {
            int totalCount = 0;
            int[] alphaCounts = new int[26];
            foreach (char thisChar in input)
            {
                int index = GetIndex(thisChar);
                if (index > -1)
                {
                    alphaCounts[index]++;
                    totalCount++;
                }
            }

            int expectedOddCounts = totalCount % 2;
            foreach (int count in alphaCounts)
            {
                if (count % 2 == 1)
                {
                    expectedOddCounts--;
                    if (expectedOddCounts < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private int GetIndex(char c)
        {
            if (c >= 65 && c <= 90)
            {
                return c - 65;
            }
            if (c >= 97 && c <= 122)
            {
                return c - 97;
            }
            return -1;
        }
    }
}
