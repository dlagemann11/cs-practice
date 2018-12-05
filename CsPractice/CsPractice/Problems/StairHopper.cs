using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.Problems
{
    public class StairHopper
    {
        private int numSolutions;

        public int BottomUpNaiveStairHop(int stairs)
        {
            numSolutions = 0;
            BottomUpNaiveHop(stairs);
            return numSolutions;
        }

        public int TopDownNaiveStairHop(int stairs)
        {
            if (stairs < 0)
            {
                return 0;
            }
            if (stairs == 0)
            {
                return 1;
            }

            return TopDownNaiveStairHop(stairs - 1) + TopDownNaiveStairHop(stairs - 2) + TopDownNaiveStairHop(stairs - 3);
        }

        public int TopDownSmartStairHop(int stairs)
        {
            int[] memo = new int[stairs + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
            return TopDownSmartHop(stairs, memo);
        }

        public int BottomUpSmartStairHop(int stairs)
        {
            if (stairs == 0)
            {
                return 0;
            }
            if (stairs == 1)
            {
                return 1;
            }
            if (stairs == 2)
            {
                return 2;
            }
            if (stairs == 3)
            {
                return 4;
            }

            int stairsBack3 = 1;
            int stairsBack2 = 2;
            int stairsBack1 = 4;
            int solution = 0;

            for (int i = 4; i <= stairs; i++)
            {
                solution = stairsBack1 + stairsBack2 + stairsBack3;
                stairsBack3 = stairsBack2;
                stairsBack2 = stairsBack1;
                stairsBack1 = solution;
            }

            return solution;
        }

        private void BottomUpNaiveHop(int stairsLeft)
        {
            if (stairsLeft > 2)
            {
                BottomUpNaiveHop(stairsLeft - 3);
            }
            if (stairsLeft > 1)
            {
                BottomUpNaiveHop(stairsLeft - 2);
            }
            if (stairsLeft > 0)
            {
                BottomUpNaiveHop(stairsLeft - 1);
            }
            if (stairsLeft == 0)
            {
                numSolutions++;
            }
        }

        private int TopDownSmartHop(int stairsLeft, int[] memo)
        {
            if (stairsLeft < 0)
            {
                return 0;
            }
            if (stairsLeft == 0)
            {
                return 1;
            }
            if (memo[stairsLeft] > -1)
            {
                return memo[stairsLeft];
            }
            memo[stairsLeft] = TopDownSmartHop(stairsLeft - 1, memo) + TopDownSmartHop(stairsLeft - 2, memo) + TopDownSmartHop(stairsLeft - 3, memo);
            return memo[stairsLeft];
        }
    }
}
