using System;
using System.Collections.Generic;

using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class LinkedListDeduper
    {
        public void DeDupeFast<T>(SingleLinkNode<T> head) where T : IComparable
        {
            HashSet<T> set = new HashSet<T>();
            set.Add(head.Data);
            SingleLinkNode<T> thisNode = head;
            while (thisNode.Next != null)
            {
                if (set.Contains(thisNode.Next.Data))
                {
                    thisNode.Next = thisNode.Next.Next;
                }
                else
                {
                    set.Add(thisNode.Next.Data);
                    thisNode = thisNode.Next;
                }
                
            }
        }

        public void DeDupeSlim<T>(SingleLinkNode<T> head) where T : IComparable
        {
            SingleLinkNode<T> thisNode = head;
            while (thisNode != null && thisNode.Next != null)
            {
                SingleLinkNode<T> compareNode = thisNode;
                while (compareNode.Next != null)
                {
                    if (thisNode.Data.CompareTo(compareNode.Next.Data) == 0)
                    {
                        compareNode.Next = compareNode.Next.Next;
                    }
                    else
                    {
                        compareNode = compareNode.Next;
                    }
                }
                thisNode = thisNode.Next;
            }
        }
    }
}
