using System;

namespace CsPractice.Problems.SortingAndSearching
{
    public class SortedArrayMerger
    {
        public void MergeSortedArrays<T>(T[] A, T[] B) where T : IComparable
        {
            int aIndex = A.Length - B.Length - 1;
            int bIndex = B.Length - 1;
            int i = A.Length - 1;
            while (bIndex >= 0)
            {
                if (aIndex < 0)
                {
                    A[i] = B[bIndex];
                    bIndex--;
                }
                else if (A[aIndex].CompareTo(B[bIndex]) > 0)
                {
                    A[i] = A[aIndex];
                    aIndex--;
                }
                else
                {
                    A[i] = B[bIndex];
                    bIndex--;
                }
                i--;
            }
        }
    }
}
