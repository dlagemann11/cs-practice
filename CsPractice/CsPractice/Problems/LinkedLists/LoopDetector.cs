using System.Collections.Generic;

using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class LoopDetector
    {
        // TODO: This is a simple, effective algorithm, but just in case the extra O(N) space complexity is unacceptable,
        // provide another solution that just uses two pointers instead of a hashset.
        public SingleLinkNode<T> DetectLoop<T>(SingleLinkNode<T> head)
        {
            HashSet<SingleLinkNode<T>> set = new HashSet<SingleLinkNode<T>>();
            SingleLinkNode<T> node = head;

            while (node != null)
            {
                if (set.Contains(node))
                {
                    return node;
                }
                set.Add(node);
                node = node.Next;
            }
            return null;
        }
    }
}
