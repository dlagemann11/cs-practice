using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
