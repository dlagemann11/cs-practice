﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Problems.StacksAndQueues;

namespace CsPracticeTests
{
    [TestClass]
    public class StacksAndQueuesTests
    {
        #region ThreeStacksFromArray

        [TestMethod]
        public void ThreeStacksFromArraySuccess()
        {
            ThreeStacksFromArray<string> stacks = GenerateThreeStacksFromArray();

            string pop1 = stacks.PopFirst();
            string pop2 = stacks.PopSecond();
            string pop3 = stacks.PopThird();
            string pop4 = stacks.PopThird();
            string pop5 = stacks.PopThird();
            string pop6 = stacks.PopThird();
            string pop7 = stacks.PopSecond();
            string pop8 = stacks.PopFirst();
            string pop9 = stacks.PopSecond();
            string pop10 = stacks.PopFirst();
            string pop11 = stacks.PopFirst();
            string pop12 = stacks.PopSecond();

            Assert.AreEqual("Stack1String4", pop1);
            Assert.AreEqual("Stack2String4", pop2);
            Assert.AreEqual("Stack3String4", pop3);
            Assert.AreEqual("Stack3String3", pop4);
            Assert.AreEqual("Stack3String2", pop5);
            Assert.AreEqual("Stack3String1", pop6);
            Assert.AreEqual("Stack2String3", pop7);
            Assert.AreEqual("Stack1String3", pop8);
            Assert.AreEqual("Stack2String2", pop9);
            Assert.AreEqual("Stack1String2", pop10);
            Assert.AreEqual("Stack1String1", pop11);
            Assert.AreEqual("Stack2String1", pop12);
        }


        private ThreeStacksFromArray<string> GenerateThreeStacksFromArray()
        {
            ThreeStacksFromArray<string> stacks = new ThreeStacksFromArray<string>();

            stacks.PushFirst("Stack1String1");
            stacks.PushFirst("Stack1String2");
            stacks.PushFirst("Stack1String3");
            stacks.PushFirst("Stack1String4");
            stacks.PushSecond("Stack2String1");
            stacks.PushThird("Stack3String1");
            stacks.PushSecond("Stack2String2");
            stacks.PushThird("Stack3String2");
            stacks.PushSecond("Stack2String3");
            stacks.PushThird("Stack3String3");
            stacks.PushSecond("Stack2String4");
            stacks.PushThird("Stack3String4");

            return stacks;
        }

        #endregion

        #region MinStack

        [TestMethod]
        public void BuildMinStackTest()
        {
            MinStack<int> min = new MinStack<int>();

            min.Push(5);
            int min1 = min.Min();
            min.Push(4);
            int min2 = min.Min();
            min.Push(6);
            int min3 = min.Min();
            min.Push(7);
            int min4 = min.Min();
            min.Push(5);
            int min5 = min.Min();
            min.Push(3);
            int min6 = min.Min();
            min.Push(10);
            int min7 = min.Min();
            min.Push(15);
            int min8 = min.Min();
            min.Push(1);
            int min9 = min.Min();

            Assert.AreEqual(5, min1);
            Assert.AreEqual(4, min2);
            Assert.AreEqual(4, min3);
            Assert.AreEqual(4, min4);
            Assert.AreEqual(4, min5);
            Assert.AreEqual(3, min6);
            Assert.AreEqual(3, min7);
            Assert.AreEqual(3, min8);
            Assert.AreEqual(1, min9);
        }

        [TestMethod]
        public void ConsumeMinStackTest()
        {
            MinStack<int> min = new MinStack<int>();

            min.Push(5);
            min.Push(4);
            min.Push(6);
            min.Push(7);
            min.Push(5);
            min.Push(3);
            min.Push(10);
            min.Push(15);
            min.Push(1);

            Assert.AreEqual(1, min.Min());            
            Assert.AreEqual(1, min.Pop());
            Assert.AreEqual(3, min.Min());
            Assert.AreEqual(15, min.Pop());
            Assert.AreEqual(3, min.Min());
            Assert.AreEqual(10, min.Pop());
            Assert.AreEqual(3, min.Min());
            Assert.AreEqual(3, min.Pop());
            Assert.AreEqual(4, min.Min());
            Assert.AreEqual(5, min.Pop());
            Assert.AreEqual(4, min.Min());
            Assert.AreEqual(7, min.Pop());
            Assert.AreEqual(4, min.Min());
            Assert.AreEqual(6, min.Pop());
            Assert.AreEqual(4, min.Min());
            Assert.AreEqual(4, min.Pop());
            Assert.AreEqual(5, min.Min());
            Assert.AreEqual(5, min.Pop());
            Assert.IsTrue(min.IsEmpty());
        }

        #endregion

        #region SetOfStacks

        [TestMethod]
        public void SetOfStacksTest()
        {
            SetOfStacks<int> stacks = new SetOfStacks<int>(3);
            stacks.Push(1);
            int count1 = stacks.StackCount;
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            int count2 = stacks.StackCount;
            stacks.Push(5);
            stacks.Push(6);
            int count3 = stacks.StackCount;
            stacks.Push(7);
            stacks.Push(8);
            int count4 = stacks.StackCount;

            int result1 = stacks.Pop();
            int result2 = stacks.Peek();
            int result3 = stacks.Pop();
            bool empty1 = stacks.IsEmpty();
            int result4 = stacks.Pop();
            int result5 = stacks.Pop();
            int result6 = stacks.Pop();
            int result7 = stacks.Pop();
            int result8 = stacks.Peek();
            stacks.Push(100);
            int result9 = stacks.Pop();
            int result10 = stacks.Pop();
            int result11 = stacks.Pop();
            bool empty2 = stacks.IsEmpty();

            Assert.AreEqual(1, count1);
            Assert.AreEqual(2, count2);
            Assert.AreEqual(2, count3);
            Assert.AreEqual(3, count4);
            Assert.AreEqual(8, result1);
            Assert.AreEqual(7, result2);
            Assert.AreEqual(7, result3);
            Assert.AreEqual(6, result4);
            Assert.AreEqual(5, result5);
            Assert.AreEqual(4, result6);
            Assert.AreEqual(3, result7);
            Assert.AreEqual(2, result8);
            Assert.AreEqual(100, result9);
            Assert.AreEqual(2, result10);
            Assert.AreEqual(1, result11);
            Assert.IsFalse(empty1);
            Assert.IsTrue(empty2);
        }

        [TestMethod]
        public void BasicPopAtSetOfStacksTest()
        {
            SetOfStacks<int> stacks = new SetOfStacks<int>(3);
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            stacks.Push(5);
            stacks.Push(6);
            stacks.Push(7);
            stacks.Push(8);

            int result1 = stacks.PopAt(1); // 1,2,3 4,5 7,8
            int result2 = stacks.Peek();
            int result3 = stacks.Pop(); // 1,2,3 4,5 7
            bool empty1 = stacks.IsEmpty();
            int result4 = stacks.Pop(); // 1,2,3 4,5
            int result5 = stacks.Pop(); // 1,2,3 4
            int result6 = stacks.PopAt(0); // 1,2 4
            stacks.Push(100); // 1,2,100 4
            int result7 = stacks.Pop(); // 1,2,100
            int result8 = stacks.Peek();            
            int result9 = stacks.Pop(); // 1,2
            int result10 = stacks.Pop(); // 1
            int result11 = stacks.Pop(); // empty
            bool empty2 = stacks.IsEmpty();

            Assert.AreEqual(6, result1);
            Assert.AreEqual(8, result2);
            Assert.AreEqual(8, result3);
            Assert.AreEqual(7, result4);
            Assert.AreEqual(5, result5);
            Assert.AreEqual(3, result6);
            Assert.AreEqual(4, result7);
            Assert.AreEqual(100, result8);
            Assert.AreEqual(100, result9);
            Assert.AreEqual(2, result10);
            Assert.AreEqual(1, result11);
            Assert.IsFalse(empty1);
            Assert.IsTrue(empty2);
        }

        [TestMethod]
        public void EmptyEarlyPopAtSetOfStacksTest()
        {
            SetOfStacks<int> stacks = new SetOfStacks<int>(3);
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            stacks.Push(5);
            stacks.Push(6);
            stacks.Push(7);
            stacks.Push(8);

            int result1 = stacks.PopAt(1); // 1,2,3 4,5 7,8
            int result2 = stacks.PopAt(1); // 1,2,3 4 7,8
            int result3 = stacks.PopAt(1); // 1,2,3 empty 7,8
            stacks.Push(100); // 1,2,3 100 7,8
            int result4 = stacks.Pop(); // 1,2,3 100 7
            int result5 = stacks.Pop(); // 1,2,3 100
            int result6 = stacks.Pop(); // 1,2,3
            int result7 = stacks.Pop(); // 1,2
            int result8 = stacks.Pop(); // 1
            int result9 = stacks.Pop(); // empty

            Assert.AreEqual(6, result1);
            Assert.AreEqual(5, result2);
            Assert.AreEqual(4, result3);
            Assert.AreEqual(8, result4);
            Assert.AreEqual(7, result5);
            Assert.AreEqual(100, result6);
            Assert.AreEqual(3, result7);
            Assert.AreEqual(2, result8);
            Assert.AreEqual(1, result9);
        }

        #endregion

        #region AnimalShelterQueue

        [TestMethod]
        public void BasicAnimalShelterQueueTest()
        {
            AnimalShelterQueue queue = new AnimalShelterQueue();
            queue.Enqueue(0, true, "Milo");
            queue.Enqueue(1, true, "Mollie");
            queue.Enqueue(2, false, "Buddy");
            queue.Enqueue(3, true, "Sylvia");
            queue.Enqueue(4, false, "Shana");
            queue.Enqueue(5, false, "Rover");
            queue.Enqueue(6, true, "Tiger");

            Animal animal1 = queue.DequeueAny(); // Milo
            Animal animal2 = queue.DequeueSpecific(false); // Buddy
            Animal animal3 = queue.DequeueSpecific(true); // Mollie
            Animal animal4 = queue.DequeueSpecific(false); // Shana
            Animal animal5 = queue.DequeueAny(); // Sylvia
            Animal animal6 = queue.DequeueSpecific(true); // Tiger
            Animal animal7 = queue.DequeueAny(); // Rover

            Assert.AreEqual("Milo", animal1.Name);
            Assert.AreEqual("Buddy", animal2.Name);
            Assert.AreEqual("Mollie", animal3.Name);
            Assert.AreEqual("Shana", animal4.Name);
            Assert.AreEqual("Sylvia", animal5.Name);
            Assert.AreEqual("Tiger", animal6.Name);
            Assert.AreEqual("Rover", animal7.Name);
        }

        #endregion

        #region QueueFromStacks

        [TestMethod]
        public void BasicQueueFromStacksTest()
        {
            QueueFromStacks queue = new QueueFromStacks();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            int result1 = queue.Dequeue();
            int result2 = queue.Dequeue();
            int result3 = queue.Peek();
            queue.Enqueue(6);
            int result3a = queue.Dequeue();
            int result4 = queue.Dequeue();
            int result5 = queue.Dequeue();
            int result6 = queue.Dequeue();

            Assert.AreEqual(1, result1);
            Assert.AreEqual(2, result2);
            Assert.AreEqual(3, result3);
            Assert.AreEqual(3, result3a);
            Assert.AreEqual(4, result4);
            Assert.AreEqual(5, result5);
            Assert.AreEqual(6, result6);
        }

        #endregion
    }
}
