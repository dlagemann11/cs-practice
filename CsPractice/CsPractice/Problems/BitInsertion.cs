using System.Collections;

namespace CsPractice.Problems
{
    public class BitInsertion
    {
        public BitArray Insert(BitArray N, BitArray M, int i, int j)
        {
            // Need to revise to use ints and use shift operators. This was cheating.
            BitArray result = new BitArray(N);
            for (int index = 0; index <= j - i; index++)
            {
                result[result.Length - 1 - i - index] = M[M.Length - 1 - index];
            }

            return result;
        }
    }
}
