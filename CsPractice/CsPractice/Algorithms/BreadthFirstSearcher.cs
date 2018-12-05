using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsPractice.DataStructures;
using CsPractice.DataStructures.Graphs;

namespace CsPractice.Algorithms
{
    public class BreadthFirstSearcher
    {
        private Graph<string> graph;

        public BreadthFirstSearcher(Graph<string> graphToSearch)
        {
            graph = graphToSearch;
        }

        public bool BreadthFirstSearch(GraphNode<string> startNode, GraphNode<string> endNode)
        {
            Queue<GraphNode<string>> adjacentNodesQueue = new Queue<GraphNode<string>>();
            bool foundPath = false;

            GraphNode<string> node = startNode;
            while (true)
            {
                VisitNode(node);
                if (node.Data == endNode.Data)
                {
                    foundPath = true;
                    break;
                }

                if (node.AdjacentNodes.Count > 0)
                {
                    AddAdjacentNodesToQueue(node, adjacentNodesQueue);
                }

                if (adjacentNodesQueue.IsEmpty())
                {
                    break;
                }

                node = adjacentNodesQueue.Dequeue();
            }

            return foundPath;
        }

        private void AddAdjacentNodesToQueue(GraphNode<string> node, Queue<GraphNode<string>> adjacentNodesQueue)
        {
            for (int i = 0; i < node.AdjacentNodes.Count; i++)
            {
                if (!node.AdjacentNodes[i].Visited)
                {
                    adjacentNodesQueue.Enqueue(node.AdjacentNodes[i]);
                }
            }
        }

        private void VisitNode(GraphNode<string> node)
        {
            node.Visited = true;
        }
    }
}
