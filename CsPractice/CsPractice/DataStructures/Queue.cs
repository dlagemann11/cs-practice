using System;

namespace CsPractice.DataStructures
{
    public class Queue<T>
    {
        private SingleLinkNode<T> front = null;
        private SingleLinkNode<T> back = null;

        public void Enqueue(T item)
        {
            SingleLinkNode<T> queueItem = new SingleLinkNode<T>(item);

            if (front == null)
            {
                front = queueItem;
                back = queueItem;
            }
            else
            {
                back.Next = queueItem;
                back = queueItem;
            }
        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new EmptyQueueException();
            }

            T item = front.Data;

            if (front.Next != null)
            {
                SingleLinkNode<T> temp = front;
                front = front.Next;
                temp.Next = null;
            }
            else
            {
                front = null;
                back = null;
            }

            return item;
        }

        public T Peek()
        {
            if (front == null)
            {
                throw new EmptyQueueException();
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }

    public class EmptyQueueException : Exception {}
}
