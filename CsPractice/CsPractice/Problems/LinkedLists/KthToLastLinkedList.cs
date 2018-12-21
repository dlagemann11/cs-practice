using System;

using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class KthToLastLinkedList
    {
        public T KthToLast<T>(int k, SingleLinkNode<T> head)
        {
            if (k < 1)
            {
                throw new ArgumentException("k must be greater than 0");
            }
            ArrayList<T> list = new ArrayList<T>();
            int i;
            for (i = 0; head != null; i++)
            {
                list.Append(head.Data);
                head = head.Next;
            }

            if (k > i)
            {
                throw new ArgumentException("k is too large for the linked list provided");
            }

            return list[i - k];
        }
    }
}
