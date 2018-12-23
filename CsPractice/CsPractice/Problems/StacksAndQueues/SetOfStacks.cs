using System;
using CsPractice.DataStructures;

namespace CsPractice.Problems.StacksAndQueues
{
    public class SetOfStacks<T>
    {
        private ArrayList<Stack<T>> stacks;
        private int popIndex = 0;
        private int pushIndex = 0;
        private readonly int capacity;

        public int StackCount { get; private set; }

        public SetOfStacks(int stackCapacity)
        {
            capacity = stackCapacity;
            stacks = new ArrayList<Stack<T>>();
            stacks.Append(new Stack<T>());
            StackCount++;
        }

        public void Push(T item)
        {
            if (stacks[pushIndex].Count >= capacity)
            {
                if (popIndex == pushIndex)
                {
                    popIndex++;
                }
                pushIndex++;
                StackCount++;

                if (stacks.Count <= pushIndex)
                {
                    stacks.Append(new Stack<T>());
                }

                Push(item);
            }
            else
            {
                stacks[pushIndex].Push(item);
            }
        }

        public T Pop()
        {
            if (CheckStacks())
            {
                return stacks[popIndex].Pop();
            }
            else
            {
                return Pop();
            }
        }

        public T PopAt(int index)
        {
            if (index >= StackCount)
            {
                throw new ArgumentException("Requested stack does not exist");
            }
            pushIndex = index;
            return stacks[index].Pop();
        }

        public T Peek()
        {
            if (CheckStacks())
            {
                return stacks[popIndex].Peek();
            }
            else
            {
                return Peek();
            }
        }

        public bool IsEmpty()
        {
            return stacks[0].IsEmpty();
        }

        private bool CheckStacks()
        {
            if (stacks[popIndex].IsEmpty() && popIndex > 0)
            {
                if (popIndex == pushIndex)
                {
                    pushIndex--;
                }
                popIndex--;
                StackCount--;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
