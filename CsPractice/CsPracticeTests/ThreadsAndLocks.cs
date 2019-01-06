using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Problems.ThreadsAndLocks;

namespace CsPracticeTests
{
    [TestClass]
    public class ThreadsAndLocks
    {
        #region DiningPhilosophersSimulation

        [TestMethod]
        public void BasicDiningPhilosophersTest()
        {
            DiningPhilosophersSimulation simulation = new DiningPhilosophersSimulation(10, 5);

            bool result = simulation.StartSimulation(1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ManyDiningPhilosophersTest()
        {
            DiningPhilosophersSimulation simulation = new DiningPhilosophersSimulation(30, 3);

            bool result = simulation.StartSimulation(1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FewDiningPhilosophersTest()
        {
            DiningPhilosophersSimulation simulation = new DiningPhilosophersSimulation(2, 3);

            bool result = simulation.StartSimulation(1);

            Assert.IsTrue(result);
        }

        #endregion

        #region InOrderCaller

        [TestMethod]
        public void BasicInOrderCallerTest()
        {
            for (int i = 0; i < 10; i++)
            {
                InOrderCaller caller = new InOrderCaller();

                List<string> result = caller.RunTest();

                Assert.AreEqual("First", result[0]);
                Assert.AreEqual("Second", result[1]);
                Assert.AreEqual("Third", result[2]);
            }
        }

        #endregion
    }
}
