namespace CsPractice.Problems.SortingAndSearching
{
    public class SparseSearcher
    {
        public int Search(string[] array, string target)
        {
            return SearchHelper(array, target, 0, array.Length - 1);
        }

        private int SearchHelper(string[] array, string target, int min, int max)
        {
            int mid = (min + max) / 2;
            int i = mid;
            while (i <= max)
            {
                if (array[i] == target)
                {
                    return i;
                }
                if (array[i] != "")
                {
                    if (array[i].CompareTo(target) > 0)
                    {
                        return SearchHelper(array, target, min, mid - 1);
                    }
                    else
                    {
                        return SearchHelper(array, target, i + 1, max);
                    }
                }
                i++;
            }

            if (min >= max)
            {
                return -1;
            }
            return SearchHelper(array, target, min, mid - 1);
        }
    }
}
