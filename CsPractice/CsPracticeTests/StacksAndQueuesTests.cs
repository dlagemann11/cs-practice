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
    }
}
