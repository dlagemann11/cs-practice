using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.Algorithms
{
    public class BitManipulator
    {
        public bool GetBit(int number, int bitIndex)
        {
            int mask = 1 << bitIndex;
            int masked = number & mask;
            return masked != 0;
        }

        public int SetBit(int number, int bitIndex)
        {
            int mask = 1 << bitIndex;
            return number | mask;
        }

        public int ClearBit(int number, int bitIndex)
        {
            int mask = 1 << bitIndex;
            mask = ~mask;
            return number & mask;
        }

        public int UpdateBit(int number, int bitIndex, bool isOne)
        {
            int mask = 1 << bitIndex;
            int flippedMask = ~mask;
            int clearedNumber = number & flippedMask;

            int bitToSet = isOne ? 1 : 0;
            int setMask = bitToSet << bitIndex;
            return clearedNumber | setMask;
        }
    }
}
