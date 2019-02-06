using CsPractice.DataStructures;

namespace CsPractice.Problems.StacksAndQueues
{
    public class QueueFromStacks
    {
        private bool IsEnqueueMode { get; set; }
        private Stack<int> EnqueueStack { get; set; }
        private Stack<int> DequeueStack { get; set; }

        public QueueFromStacks()
        {
            IsEnqueueMode = true;
            EnqueueStack = new Stack<int>();
            DequeueStack = new Stack<int>();
        }

        public void Enqueue(int item)
        {
            if (!IsEnqueueMode)
            {
                SwitchStacks(DequeueStack, EnqueueStack);
                IsEnqueueMode = true;
            }
            EnqueueStack.Push(item);
        }

        public int Peek()
        {
            if (IsEnqueueMode)
            {
                SwitchStacks(EnqueueStack, DequeueStack);
                IsEnqueueMode = false;
            }
            return DequeueStack.Peek();
        }

        public int Dequeue()
        {
            if (IsEnqueueMode)
            {
                SwitchStacks(EnqueueStack, DequeueStack);
                IsEnqueueMode = false;
            }
            return DequeueStack.Pop();
        }

        private void SwitchStacks(Stack<int> from, Stack<int> to)
        {
            while (!from.IsEmpty())
            {
                to.Push(from.Pop());
            }
        }
    } 
}
