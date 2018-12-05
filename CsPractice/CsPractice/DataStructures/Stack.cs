using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures
{
    public class Stack<T>
    {
        private SingleLinkNode<T> top = null;
        
        public void Push(T item)
        {
            SingleLinkNode<T> stackItem = new SingleLinkNode<T>(item);
            if (top != null)
            {
                stackItem.Next = top;
            }

            top = stackItem;
        }

        public T Pop()
        {            
            if (top == null)
            {
                throw new EmptyStackException();
            }

            T item = top.Data;

            if (top.Next != null)
            {
                top = top.Next;
            }
            else
            {
                top = null;
            }

            return item;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new EmptyStackException();
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class EmptyStackException : Exception {}
}
