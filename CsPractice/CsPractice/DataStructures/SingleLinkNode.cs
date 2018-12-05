using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures
{
    public class SingleLinkNode<T>
    {
        public T Data { get; }
        public SingleLinkNode<T> Next { get; set; }

        public SingleLinkNode(T data)
        {
            Data = data;
            Next = null;
        }

        public SingleLinkNode<T> Add(T data)
        {
            SingleLinkNode<T> node = new SingleLinkNode<T>(data);
            Next = node;
            return node;
        }
    }
}
