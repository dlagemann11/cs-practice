namespace CsPractice.Problems.Recursion
{
    public class MagicIndexFinder
    {
        public int FindMagicIndex(int[] A)
        {
            return BinarySearch(A, A.Length / 2, 0, A.Length - 1);
        }

        private int BinarySearch(int[] array, int index, int leftBoundary, int rightBoundary)
        {
            if (array[index] == index)
            {
                return index;
            }
            if (leftBoundary == rightBoundary)
            {
                return -1;
            }

            if (array[index] > index)
            {
                return BinarySearch(array, (leftBoundary + index) / 2, leftBoundary, index - 1);
            }
            else
            {
                return BinarySearch(array, ((index + rightBoundary) / 2) + 1, index + 1, rightBoundary);
            }
        }

        public int FindNonDistinctMagicIndex(int[] A)
        {
            // This might be able to be improved by sticking with the binary search approach but account for the fact that we might have to
            // recursively search both sides of the array, intelligently setting the start, end, and midpoint according to what A[i] was.
            int i = 0;
            while (i < A.Length)
            {
                if (A[i] == i)
                {
                    return i;
                }

                if (A[i] > i)
                {
                    i = A[i];
                }
                else
                {
                    i++;
                }
            }

            return -1;
        }
    }
}
