using System.Collections.Generic;

using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class LoopDetector
    {
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
