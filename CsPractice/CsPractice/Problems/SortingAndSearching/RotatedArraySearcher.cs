namespace CsPractice.Problems.SortingAndSearching
{
    public class RotatedArraySearcher
    {
        public int Search(int[] array, int target)
        {
            return Find(array, target, 0, array.Length - 1);
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

            if (array[leftBound] < array[mid])
            {
                if (array[leftBound] <= target && target < array[mid])
                {
                    return Find(array, target, leftBound, mid - 1);
                }
                else
                {
                    return Find(array, target, mid + 1, rightBound);
                }
            }
            if (array[mid] < array[rightBound])
            {
                if (array[mid] < target && target <= array[rightBound])
                {
                    return Find(array, target, mid + 1, rightBound);
                }
                else
                {
                    return Find(array, target, leftBound, mid - 1);
                }
            }

            if (array[leftBound] == array[mid])
            {
                if (array[mid] != array[rightBound])
                {
                    return Find(array, target, mid + 1, rightBound);
                }

                int leftResult = Find(array, target, leftBound, mid - 1);
                if (leftResult != -1)
                {
                    return leftResult;
                }
                return Find(array, target, mid + 1, rightBound);
            }
            else if (array[mid] == array[rightBound])
            {
                if (array[mid] != array[leftBound])
                {
                    return Find(array, target, leftBound, mid - 1);
                }

                int leftResult = Find(array, target, leftBound, mid - 1);
                if (leftResult != -1)
                {
                    return leftResult;
                }
                return Find(array, target, mid + 1, rightBound);
            }

            return -1;
        }
    }
}
