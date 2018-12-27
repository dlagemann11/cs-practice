using CsPractice.DataStructures;

namespace CsPractice.Problems.LinkedLists
{
    public class LinkedListReverser
    {
        public SingleLinkNode<T> Reverse<T>(SingleLinkNode<T> head)
        {
            SingleLinkNode<T> thisNode = head;
            SingleLinkNode<T> nextNode = null;
            SingleLinkNode<T> prevNode = null;
            while (thisNode != null)
            {
                nextNode = thisNode.Next;
                thisNode.Next = prevNode;
                prevNode = thisNode;
                thisNode = nextNode;
            }
            return prevNode;
        }
    }
}
