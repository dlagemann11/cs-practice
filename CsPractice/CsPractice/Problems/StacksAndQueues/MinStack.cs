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
            else
            {
                minStack.Push(minStack.Peek());
            }
        }

        public override T Pop()
        {
            T popped = base.Pop();
            minStack.Pop();
            return popped;
        }

        public T Min()
        {
            return minStack.Peek();
        }
    }
}
