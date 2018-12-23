using System;

using CsPractice.DataStructures;

namespace CsPractice.Problems.StacksAndQueues
{
    public class MinStack<T> : Stack<T> where T : IComparable
    {
        private Stack<T> minStack = new Stack<T>();

        public override void Push(T item)
        {
            base.Push(item);
            if (minStack.IsEmpty() || minStack.Peek().CompareTo(item) >= 0)
            {
                minStack.Push(item);
            }
        }

        public override T Pop()
        {
            if (Peek().CompareTo(minStack.Peek()) == 0)
            {
                minStack.Pop();
            }            
            return base.Pop();
        }

        public T Min()
        {
            return minStack.Peek();
        }
    }
}
