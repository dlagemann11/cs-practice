namespace CsPractice.Problems.BitManipulation
{
    public class BitConvertCounter
    {
        public int Count(int a, int b)
        {
            int ones = a ^ b;
            uint uOnes = (uint)ones;
            int count = 0;
            while (uOnes > 0)
            {
                if ((uOnes & 1) == 1)
                {
                    count++;
                }
                uOnes >>= 1;
            }
            return count;
        }
    }
}
