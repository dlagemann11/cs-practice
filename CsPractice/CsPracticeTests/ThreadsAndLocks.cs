using System;
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
    }
}
