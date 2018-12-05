using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsPractice.DataStructures;
using CsPractice.DataStructures.Graphs;

namespace CsPractice.Algorithms
{
    public class DepthFirstSearcher
    {
        private Graph<string> graph;

        public DepthFirstSearcher(Graph<string> graphToSearch)
        {
            graph = graphToSearch;
        }

        public bool DepthFirstSearch(GraphNode<string> startNode, GraphNode<string> endNode)
        {
            Stack<GraphNode<string>> adjacentNodesStack = new Stack<GraphNode<string>>();
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
                    AddAdjacentNodesToStack(node, adjacentNodesStack);
                }

                if (adjacentNodesStack.IsEmpty())
                {
                    break;
                }

                node = adjacentNodesStack.Pop();
            }

            return foundPath;
        }

        private void AddAdjacentNodesToStack(GraphNode<string> node, Stack<GraphNode<string>> adjacentNodesStack)
        {
            for (int i = 0; i < node.AdjacentNodes.Count; i++)
            {
                if (!node.AdjacentNodes[i].Visited)
                {
                    adjacentNodesStack.Push(node.AdjacentNodes[i]);
                }
            }
        }

        private void VisitNode(GraphNode<string> node)
        {
            node.Visited = true;
        }
    }
}
