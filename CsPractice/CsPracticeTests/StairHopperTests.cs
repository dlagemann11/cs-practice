using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Problems;

namespace CsPracticeTests
{
    [TestClass]
    public class StairHopperTests
    {
        [TestMethod]
        public void BottomUpOneStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpNaiveStairHop(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void BottomUpTwoStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpNaiveStairHop(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BottomUpThreeStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpNaiveStairHop(3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void BottomUpThirtyStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpNaiveStairHop(30);

            Assert.AreEqual(53798080, result);
        }

        [TestMethod]
        public void BottomUpOneStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpSmartStairHop(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void BottomUpTwoStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpSmartStairHop(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BottomUpThreeStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpSmartStairHop(3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void BottomUpThirtyStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.BottomUpSmartStairHop(30);

            Assert.AreEqual(53798080, result);
        }

        [TestMethod]
        public void TopDownOneStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownNaiveStairHop(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TopDownTwoStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownNaiveStairHop(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TopDownThreeStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownNaiveStairHop(3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TopDownThirtyStairNaive()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownNaiveStairHop(30);

            Assert.AreEqual(53798080, result);
        }

        [TestMethod]
        public void TopDownOneStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownSmartStairHop(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TopDownTwoStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownSmartStairHop(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TopDownThreeStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownSmartStairHop(3);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TopDownThirtyStairSmart()
        {
            StairHopper hopper = new StairHopper();

            int result = hopper.TopDownSmartStairHop(30);

            Assert.AreEqual(53798080, result);
        }
    }
}
