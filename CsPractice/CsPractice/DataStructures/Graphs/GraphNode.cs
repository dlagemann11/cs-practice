using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures.Graphs
{
    public class GraphNode<T>
    {
        public T Data { get; }
        public ArrayList<GraphNode<T>> AdjacentNodes { get; }
        public bool Visited { get; set; }

        public GraphNode(T data)
        {
            Data = data;
            AdjacentNodes = new ArrayList<GraphNode<T>>();
            Visited = false;
        }

        public void AddOneWayAdjacent(GraphNode<T> node)
        {
            AdjacentNodes.Append(node);
        }

        public void AddTwoWayAdjacent(GraphNode<T> node)
        {
            AdjacentNodes.Append(node);
            node.AddOneWayAdjacent(this);
        }
    }
}
