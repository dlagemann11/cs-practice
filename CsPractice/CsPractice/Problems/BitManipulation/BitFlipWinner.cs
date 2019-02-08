namespace CsPractice.Problems.BitManipulation
{
    public class BitFlipWinner
    {
        public int Evaluate(int number)
        {
            int longestSequence = 1;
            int leftSequence = 0;
            int rightSequence = 0;
            uint uNumber = (uint)number;
            while (uNumber != 0)
            {
                if ((uNumber & 1) == 1)
                {
                    rightSequence++;
                }
                else
                {
                    leftSequence = rightSequence + 1;
                    rightSequence = 0;
                }
                uNumber >>= 1;

                if (leftSequence + rightSequence > longestSequence)
                {
                    longestSequence = leftSequence + rightSequence;
                }                
            }

            return longestSequence;
        }
    }
}
