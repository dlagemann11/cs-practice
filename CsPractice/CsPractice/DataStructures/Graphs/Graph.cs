using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures.Graphs
{
    public class Graph<T> where T : IEquatable<T>
    {
        public ArrayList<GraphNode<T>> Nodes = new ArrayList<GraphNode<T>>();

        public GraphNode<T> Find(T data)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].Data.Equals(data))
                {
                    return Nodes[i];
                }
            }

            throw new NodeNotFoundException();
        }

        public int CountVisited()
        {
            int count = 0;
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].Visited)
                {
                    count++;
                }
            }

            return count;
        }
    }

    public class NodeNotFoundException : Exception {}
}
