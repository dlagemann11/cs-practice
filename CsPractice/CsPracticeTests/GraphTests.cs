using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CsPractice.DataStructures.Graphs;
using CsPractice.Algorithms;

namespace CsPracticeTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void TestGraphTraversal()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();

            GraphNode<string> node = graph.Find("Jeff");
            Assert.AreEqual("Jeff", node.Data);

            node = node.AdjacentNodes[0];
            Assert.AreEqual("Chris", node.Data);

            node = node.AdjacentNodes[0];
            Assert.AreEqual("Disney", node.Data);

            node = node.AdjacentNodes[0];
            Assert.AreEqual("Ginger", node.Data);

            node = GoToNode(node, "Emily");
            Assert.AreEqual("Emily", node.Data);

            node = GoToNode(node, "Moe");
            Assert.AreEqual("Moe", node.Data);

            node = GoToNode(node, "John");
            Assert.AreEqual("John", node.Data);

            node = GoToNode(node, "Dan");
            Assert.AreEqual("Dan", node.Data);

            node = GoToNode(node, "Allison");
            Assert.AreEqual("Allison", node.Data);

            node = GoToNode(node, "Amy");
            Assert.AreEqual("Amy", node.Data);
        }

        [TestMethod]
        public void TestGraphDeadEnd()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();

            GraphNode<string> node = graph.Find("Jane");
            Assert.AreEqual("Jane", node.Data);
            Assert.AreEqual(3, node.AdjacentNodes.Count);

            node = GoToNode(node, "Harry");
            Assert.AreEqual("Harry", node.Data);
            Assert.AreEqual(0, node.AdjacentNodes.Count);
        }

        [TestMethod]
        public void TestDepthFirstSearchLong()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();
            DepthFirstSearcher searcher = new DepthFirstSearcher(graph);
            GraphNode<string> startNode = graph.Find("Jeff");
            GraphNode<string> endNode = graph.Find("Abby");

            bool foundPath = searcher.DepthFirstSearch(startNode, endNode);

            Assert.IsTrue(foundPath);
            Assert.AreEqual(20, graph.CountVisited());
        }

        [TestMethod]
        public void TestDepthFirstSearchShort()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();
            DepthFirstSearcher searcher = new DepthFirstSearcher(graph);
            GraphNode<string> startNode = graph.Find("Microsoft");
            GraphNode<string> endNode = graph.Find("Amy");

            bool foundPath = searcher.DepthFirstSearch(startNode, endNode);

            Assert.IsTrue(foundPath);
            Assert.AreEqual(9, graph.CountVisited());
        }

        [TestMethod]
        public void TestDepthFirstSearchNoPath()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();
            DepthFirstSearcher searcher = new DepthFirstSearcher(graph);
            GraphNode<string> startNode = graph.Find("Jeff");
            GraphNode<string> endNode = graph.Find("Amazon");

            bool foundPath = searcher.DepthFirstSearch(startNode, endNode);

            Assert.IsFalse(foundPath);
            Assert.AreEqual(20, graph.CountVisited());
        }

        [TestMethod]
        public void TestBreadthFirstSearchShort()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();
            BreadthFirstSearcher searcher = new BreadthFirstSearcher(graph);
            GraphNode<string> startNode = graph.Find("Jeff");
            GraphNode<string> endNode = graph.Find("Abby");

            bool foundPath = searcher.BreadthFirstSearch(startNode, endNode);

            Assert.IsTrue(foundPath);
            Assert.AreEqual(7, graph.CountVisited());
        }

        [TestMethod]
        public void TestBreadthFirstSearchLong()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();
            BreadthFirstSearcher searcher = new BreadthFirstSearcher(graph);
            GraphNode<string> startNode = graph.Find("Microsoft");
            GraphNode<string> endNode = graph.Find("Amy");

            bool foundPath = searcher.BreadthFirstSearch(startNode, endNode);

            Assert.IsTrue(foundPath);
            Assert.AreEqual(18, graph.CountVisited());
        }

        [TestMethod]
        public void TestBreadthFirstSearchNoPath()
        {
            Graph<string> graph = TestUtilities.GenerateNameGraph();
            BreadthFirstSearcher searcher = new BreadthFirstSearcher(graph);
            GraphNode<string> startNode = graph.Find("Jeff");
            GraphNode<string> endNode = graph.Find("Amazon");

            bool foundPath = searcher.BreadthFirstSearch(startNode, endNode);

            Assert.IsFalse(foundPath);
            Assert.AreEqual(20, graph.CountVisited());
        }

        private GraphNode<T> GoToNode<T>(GraphNode<T> startNode, T data) where T : IEquatable<T>
        {
            for (int i = 0; i < startNode.AdjacentNodes.Count; i++)
            {
                if (startNode.AdjacentNodes[i].Data.Equals(data))
                {
                    return startNode.AdjacentNodes[i];
                }
            }

            return startNode;
        }
    }
}
