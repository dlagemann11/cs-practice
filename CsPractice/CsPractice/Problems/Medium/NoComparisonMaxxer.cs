namespace CsPractice.Problems.Medium
{
    public class NoComparisonMaxxer
    {
        public int Max(int a, int b)
        {
            // Works as long as b - a doesn't overflow
            int diff = b - a;
            int isAGreater = (int)((uint)diff >> 31);

            return a * isAGreater + (b * (isAGreater ^ 1));
        }
    }
}
