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

        #region MultiThreadedFizzBuzz

        [TestMethod]
        public void BasicMultiThreadedFizzBuzzTest()
        {
            MultiThreadedFizzBuzz fizzBuzz = new MultiThreadedFizzBuzz();

            List<string> result = fizzBuzz.RunTest(15);

            Assert.AreEqual("1", result[1]);
            Assert.AreEqual("2", result[2]);
            Assert.AreEqual("Fizz", result[3]);
            Assert.AreEqual("4", result[4]);
            Assert.AreEqual("Buzz", result[5]);
            Assert.AreEqual("Fizz", result[6]);
            Assert.AreEqual("7", result[7]);
            Assert.AreEqual("8", result[8]);
            Assert.AreEqual("Fizz", result[9]);
            Assert.AreEqual("Buzz", result[10]);
            Assert.AreEqual("11", result[11]);
            Assert.AreEqual("Fizz", result[12]);
            Assert.AreEqual("13", result[13]);
            Assert.AreEqual("14", result[14]);
            Assert.AreEqual("FizzBuzz", result[15]);
        }

        [TestMethod]
        public void BigMultiThreadedFizzBuzzTest()
        {
            MultiThreadedFizzBuzz fizzBuzz = new MultiThreadedFizzBuzz();

            List<string> result = fizzBuzz.RunTest(150);

            Assert.AreEqual("1", result[1]);
            Assert.AreEqual("2", result[2]);
            Assert.AreEqual("Fizz", result[3]);
            Assert.AreEqual("4", result[4]);
            Assert.AreEqual("Buzz", result[5]);
            Assert.AreEqual("Fizz", result[6]);
            Assert.AreEqual("7", result[7]);
            Assert.AreEqual("8", result[8]);
            Assert.AreEqual("Fizz", result[9]);
            Assert.AreEqual("Buzz", result[10]);
            Assert.AreEqual("11", result[11]);
            Assert.AreEqual("Fizz", result[12]);
            Assert.AreEqual("13", result[13]);
            Assert.AreEqual("14", result[14]);
            Assert.AreEqual("FizzBuzz", result[15]);
            Assert.AreEqual("FizzBuzz", result[30]);
            Assert.AreEqual("Fizz", result[99]);
            Assert.AreEqual("Buzz", result[100]);
            Assert.AreEqual("101", result[101]);
            Assert.AreEqual("FizzBuzz", result[150]);
        }

        #endregion
    }
}
