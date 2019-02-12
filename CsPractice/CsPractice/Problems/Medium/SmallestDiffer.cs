using System;

namespace CsPractice.Problems.Medium
{
    public class SmallestDiffer
    {
        public int GetSmallestDiff(int[] a, int[] b)
        {
            int smallestDiff = int.MaxValue;
            Array.Sort(a);
            Array.Sort(b);
            int aIndex = 0;
            int bIndex = 0;

            while (aIndex < a.Length && bIndex < b.Length)
            {
                int diff = Math.Abs(a[aIndex] - b[bIndex]);
                if (diff < smallestDiff)
                {
                    smallestDiff = diff;
                }

                if (a[aIndex] > b[bIndex])
                {
                    bIndex++;
                }
                else
                {
                    aIndex++;
                }
            }

            return smallestDiff;
        }
    }
}
