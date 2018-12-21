namespace CsPractice.Problems.ArraysAndStrings
{
    public class OneAwayChecker
    {
        public bool IsOneAway(string a, string b)
        {
            if (a.Length == b.Length)
            {
                return ReplaceCheck(a, b);
            }
            else if (a.Length == b.Length + 1)
            {
                return RemoveCheck(a, b);
            }
            else if (b.Length == a.Length + 1)
            {
                return RemoveCheck(b, a);
            }
            return false;
        }

        private bool ReplaceCheck(string a, string b)
        {
            bool replaced = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    if (!replaced)
                    {
                        replaced = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool RemoveCheck(string a, string b)
        {
            int aIndex = 0;
            int bIndex = 0;
            for (; aIndex < a.Length;) // Assignment and increment empty by design
            {
                if (bIndex >= b.Length)
                {
                    return true;
                }
                if (a[aIndex] == b[bIndex])
                {
                    aIndex++;
                    bIndex++;
                }
                else
                {
                    if (aIndex == bIndex)
                    {
                        aIndex++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
