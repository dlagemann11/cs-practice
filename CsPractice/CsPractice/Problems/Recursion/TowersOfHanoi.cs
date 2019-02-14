using System.Collections.Generic;

namespace CsPractice.Problems.Recursion
{
    public class TowersOfHanoi
    {
        public void MoveDisks(Stack<int> origin, Stack<int> dest, Stack<int> buff, int numDisks)
        {
            if (numDisks <= 0)
            {
                return;
            }
            MoveDisks(origin, buff, dest, numDisks - 1);
            MoveTop(origin, dest);
            MoveDisks(buff, dest, origin, numDisks - 1);
        }
        private void MoveTop(Stack<int> origin, Stack<int> dest)
        {
            dest.Push(origin.Pop());
        }
    }
}
