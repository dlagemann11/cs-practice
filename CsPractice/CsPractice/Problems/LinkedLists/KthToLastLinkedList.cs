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

            SingleLinkNode<T> currentNode = head;
            SingleLinkNode<T> runnerNode = head;
            for (int i = 1; i < k; i++)
            {
                runnerNode = runnerNode.Next;
                if (runnerNode == null)
                {
                    throw new ArgumentException("k is too large for the linked list provided.");
                }
            }

            while (runnerNode.Next != null)
            {
                currentNode = currentNode.Next;
                runnerNode = runnerNode.Next;
            }

            return currentNode.Data;
        }
    }
}
