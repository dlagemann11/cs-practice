using System;
using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class LinkedListPalindromeChecker
    {
        public bool Check<T>(SingleLinkNode<T> head) where T : IComparable
        {
            Stack<T> stack = new Stack<T>();
            SingleLinkNode<T> node = head;
            while (node != null)
            {
                stack.Push(node.Data);
                node = node.Next;
            }

            node = head;
            while (node != null)
            {
                if (stack.Pop().CompareTo(node.Data) != 0)
                {
                    return false;
                }
                node = node.Next;
            }

            return true;
        }
    }
}
