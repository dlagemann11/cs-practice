using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures
{
    public class DoubleLinkNode<T>
    {
        public T Data { get; }
        public DoubleLinkNode<T> Next { get; set; }
        public DoubleLinkNode<T> Last { get; set; }

        public DoubleLinkNode(T data)
        {
            Data = data;
            Next = null;
            Last = null;
        }

        public DoubleLinkNode<T> AddNext(T data)
        {
            DoubleLinkNode<T> nextNode = new DoubleLinkNode<T>(data);
            Next = nextNode;
            nextNode.Last = this;
            return nextNode;
        }

        public DoubleLinkNode<T> AddLast(T data)
        {
            DoubleLinkNode<T> lastNode = new DoubleLinkNode<T>(data);
            Last = lastNode;
            lastNode.Next = this;
            return lastNode;
        }
    }
}
