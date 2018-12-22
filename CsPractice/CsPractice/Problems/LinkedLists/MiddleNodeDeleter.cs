using System;

using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class MiddleNodeDeleter
    {
        public void Delete<T>(SingleLinkNode<T> node)
        {
            if (node.Next == null)
            {
                throw new ArgumentException("Node to delete cannot be the last node in the list");
            }

            node.Data = node.Next.Data;
            node.Next = node.Next.Next;
        }
    }
}
