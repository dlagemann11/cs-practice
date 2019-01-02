namespace CsPractice.Problems.SortingAndSearching
{
    // This can probably be improved by using a hashtable and assuming we can sort the chars within a string efficiently using library functions
    // The key to the hashtable will be the char sorted version of the string, any anagram of that string should have the same key
    public class AnagramSorter
    {
        public void AnagramSort(string[] array)
        {
            int currentIndex = 0;
            int targetIndex = 1;
            int i = 1;
            while (targetIndex < array.Length)
            {
                int[] currentChars = CreateCharSet(array[currentIndex]);
                while (i < array.Length)
                {
                    if (array[currentIndex].Length == array[i].Length)
                    {
                        if (CompareCharSet(currentChars, array[i]))
                        {
                            string tempString = array[targetIndex];
                            array[targetIndex] = array[i];
                            array[i] = tempString;

                            targetIndex++;
                        }
                    }
                    i++;
                }
                currentIndex = targetIndex;
                targetIndex = currentIndex + 1;
                i = targetIndex;
            }
        }

        private int[] CreateCharSet(string s)
        {
            int[] charSet = new int[256];
            foreach (char c in s)
            {
                charSet[c]++;
            }
            return charSet;
        }

        private bool CompareCharSet(int[] charSet, string s)
        {
            int[] tempCharSet = new int[charSet.Length];
            charSet.CopyTo(tempCharSet, 0);

            foreach (char c in s)
            {
                tempCharSet[c]--;
                if (tempCharSet[c] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
