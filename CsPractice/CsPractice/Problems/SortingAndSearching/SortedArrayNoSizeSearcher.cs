namespace CsPractice.Problems.SortingAndSearching
{
    public class SortedArrayNoSizeSearcher
    {
        public int Search(int[] array, int target)
        {
            int rightBound = FindEnd(array, target);
            return Find(array, target, rightBound / 2, rightBound);
        }

        private int FindEnd(int[] array, int target)
        {
            int i = 1;
            while (array[i] != -1 && array[i] < target)
            {
                i *= 2;
            }
            return i;
        }

        private int Find(int[] array, int target, int leftBound, int rightBound)
        {
            int mid = (leftBound + rightBound) / 2;
            if (array[mid] == target)
            {
                return mid;
            }
            if (rightBound <= leftBound)
            {
                return -1;
            }

            if (array[mid] > target || array[mid] == -1)
            {
                return Find(array, target, leftBound, mid - 1);
            }
            else
            {
                return Find(array, target, mid + 1, rightBound);
            }
        }
    }
}
