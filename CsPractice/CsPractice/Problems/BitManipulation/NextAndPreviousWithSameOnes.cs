namespace CsPractice.Problems
{
    public class NextAndPreviousWithSameOnesSolver
    {
        // TODO: Not the optimal solution. This is the simplest solution. Replace with a more optimal solution.
        // Also this solution cannot handle inputs like 15 where it will have to go into massive negative numbers.
        // It works but it took 43 seconds to solve for 15! So for now it returns -1 if it cannot find a positive solution.
        public int[] Solve(int number)
        {
            if (number < 1)
            {
                return new int[] { -1, -1 };
            }
            int[] solution = new int[2];
            int ones = CountOnes(number);
            int workingNumber = number;
            while (true)
            {
                workingNumber++;
                if (CountOnes(workingNumber) == ones)
                {
                    solution[0] = workingNumber;
                    break;
                }
            }
            workingNumber = number;
            while (true)
            {
                workingNumber--;
                if (workingNumber < 0)
                {
                    solution[1] = -1;
                    break;
                }
                if (CountOnes(workingNumber) == ones)
                {
                    solution[1] = workingNumber;
                    break;
                }
            }
            return solution;
        }

        private int CountOnes(int number)
        {
            uint uNumber = (uint)number;
            int count = 0;
            while (uNumber != 0)
            {
                if ((uNumber & 1) == 1)
                {
                    count++;
                }
                uNumber >>= 1;
            }
            return count;
        }
    }
}
