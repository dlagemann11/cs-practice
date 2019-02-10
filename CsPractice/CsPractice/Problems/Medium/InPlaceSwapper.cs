namespace CsPractice.Problems.Medium
{
    public class InPlaceSwapper
    {
        public void Swap(ref int a, ref int b)
        {
            b = b - a;
            a = a + b;
            b = a - b;
        }
    }
}
