namespace CsPractice.Problems.Recursion
{
    public class RecursiveMultiplier
    {
        public int Multiply(int a, int b)
        {
            if (a > b)
            {
                return MultiplyDown(b, a);
            }
            else
            {
                return MultiplyDown(a, b);
            }
        }

        private int MultiplyDown(int count, int adder)
        {
            if (count == 1)
            {
                return adder;
            }
            if (count % 2 == 0)
            {
                count >>= 1;
                return MultiplyDown(count, adder) << 1;
            }
            else
            {
                count >>= 1;
                return (MultiplyDown(count, adder) << 1) + adder;
            }
        }
    }
}
