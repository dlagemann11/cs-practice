using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.Problems.Recursion;

namespace CsPracticeTests
{
    [TestClass]
    public class RecursionTests
    {
        #region StairHopper

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

        #endregion

        #region RobotGridPathfinder

        [TestMethod]
        public void BasicRobotGridPathfinderTest()
        {
            RobotGridPathfinder pathfinder = new RobotGridPathfinder();
            bool[,] grid = GenerateGrid();

            bool[,] result = pathfinder.FindPath(grid);

            Assert.IsTrue(result[0, 0]);
            Assert.IsTrue(result[0, 1]);
            Assert.IsTrue(result[0, 2]);
            Assert.IsTrue(result[1, 2]);
            Assert.IsTrue(result[1, 3]);
            Assert.IsTrue(result[2, 3]);
            Assert.IsTrue(result[3, 3]);
            Assert.IsTrue(result[4, 3]);
            Assert.IsTrue(result[4, 4]);

            Assert.IsFalse(result[0, 3]);
            Assert.IsFalse(result[0, 4]);
            Assert.IsFalse(result[1, 0]);
            Assert.IsFalse(result[1, 1]);
            Assert.IsFalse(result[1, 4]);
            Assert.IsFalse(result[2, 0]);
            Assert.IsFalse(result[2, 1]);
            Assert.IsFalse(result[2, 2]);
            Assert.IsFalse(result[2, 4]);
            Assert.IsFalse(result[3, 0]);
            Assert.IsFalse(result[3, 1]);
            Assert.IsFalse(result[3, 2]);
            Assert.IsFalse(result[3, 4]);
            Assert.IsFalse(result[4, 0]);
            Assert.IsFalse(result[4, 1]);
            Assert.IsFalse(result[4, 2]);
        }

        [TestMethod]
        public void NoPathRobotGridPathfinderTest()
        {
            RobotGridPathfinder pathfinder = new RobotGridPathfinder();
            bool[,] grid = GenerateGrid();
            grid[1, 2] = false;

            bool[,] result = pathfinder.FindPath(grid);

            Assert.IsNull(result);
        }

        private bool[,] GenerateGrid()
        {
            bool[,] grid = new bool[5, 5];
            grid[0, 0] = true;
            grid[0, 1] = true;
            grid[0, 2] = true;
            grid[0, 4] = true;
            grid[1, 2] = true;
            grid[1, 3] = true;
            grid[1, 4] = true;
            grid[2, 0] = true;
            grid[2, 1] = true;
            grid[2, 3] = true;
            grid[2, 4] = true;
            grid[3, 0] = true;
            grid[3, 1] = true;
            grid[3, 3] = true;
            grid[4, 0] = true;
            grid[4, 1] = true;
            grid[4, 2] = true;
            grid[4, 3] = true;
            grid[4, 4] = true;

            return grid;
        }

        #endregion
    }
}
