namespace CsPractice.Problems.BitManipulation
{
    public class BitInserter
    {
        public int Insert(int N, int M, int i, int j)
        {
            int length = j - i + 1;
            int mask = GetMask(length, i);

            // Clear bits in the insertion range on the target number
            mask = ~mask;
            N &= mask;

            // Shift M's bits over to the start of the insertion range, then OR them in.
            M <<= i;
            N |= M;

            return N;
        }

        private int GetMask(int length, int bitIndexStart)
        {
            int mask = 0;
            for (int i = 0; i < length; i++)
            {
                mask <<= 1;
                mask |= 1;
            }
            mask <<= bitIndexStart;
            return mask;
        }
    }
}
