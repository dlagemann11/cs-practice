using System;

using CsPractice.DataStructures.Graphs;

namespace CsPracticeTests
{
    public class TestUtilities
    {
        public static bool IsSorted<T>(T[] array) where T : IComparable
        {
            if (array.Length < 2)
            {
                return true;
            }

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] GenerateIntArray(int size, int minValue = 0, int maxValue = Int32.MaxValue)
        {
            int[] array = new int[size];
            Random ran = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = ran.Next(minValue, maxValue);
            }
            return array;
        }

        public static Graph<string> GenerateNameGraph()
        {
            Graph<string> graph = new Graph<string>();
            GraphNode<string> jeffNode = new GraphNode<string>("Jeff");
            GraphNode<string> chrisNode = new GraphNode<string>("Chris");
            GraphNode<string> disneyNode = new GraphNode<string>("Disney");
            GraphNode<string> gingerNode = new GraphNode<string>("Ginger");
            GraphNode<string> emilyNode = new GraphNode<string>("Emily");
            GraphNode<string> moeNode = new GraphNode<string>("Moe");
            GraphNode<string> abbyNode = new GraphNode<string>("Abby");
            GraphNode<string> amazonNode = new GraphNode<string>("Amazon");
            GraphNode<string> googleNode = new GraphNode<string>("Google");
            GraphNode<string> microsoftNode = new GraphNode<string>("Microsoft");
            GraphNode<string> joeNode = new GraphNode<string>("Joe");
            GraphNode<string> jacobNode = new GraphNode<string>("Jacob");
            GraphNode<string> bobNode = new GraphNode<string>("Bob");
            GraphNode<string> janeNode = new GraphNode<string>("Jane");
            GraphNode<string> harryNode = new GraphNode<string>("Harry");
            GraphNode<string> lauraNode = new GraphNode<string>("Laura");
            GraphNode<string> robinNode = new GraphNode<string>("Robin");
            GraphNode<string> amyNode = new GraphNode<string>("Amy");
            GraphNode<string> maryNode = new GraphNode<string>("Mary");
            GraphNode<string> allisonNode = new GraphNode<string>("Allison");
            GraphNode<string> danNode = new GraphNode<string>("Dan");
            GraphNode<string> johnNode = new GraphNode<string>("John");
            GraphNode<string> daleNode = new GraphNode<string>("Dale");

            jeffNode.AddOneWayAdjacent(chrisNode);
            chrisNode.AddOneWayAdjacent(disneyNode);
            disneyNode.AddOneWayAdjacent(gingerNode);
            gingerNode.AddOneWayAdjacent(chrisNode);
            gingerNode.AddTwoWayAdjacent(emilyNode);
            emilyNode.AddTwoWayAdjacent(moeNode);
            moeNode.AddTwoWayAdjacent(abbyNode);
            moeNode.AddTwoWayAdjacent(joeNode);
            moeNode.AddTwoWayAdjacent(jacobNode);
            moeNode.AddTwoWayAdjacent(johnNode);
            amazonNode.AddOneWayAdjacent(abbyNode);
            amazonNode.AddTwoWayAdjacent(googleNode);
            amazonNode.AddTwoWayAdjacent(microsoftNode);
            googleNode.AddTwoWayAdjacent(microsoftNode);
            jacobNode.AddTwoWayAdjacent(bobNode);
            bobNode.AddTwoWayAdjacent(maryNode);
            johnNode.AddTwoWayAdjacent(daleNode);
            johnNode.AddOneWayAdjacent(danNode);
            danNode.AddOneWayAdjacent(allisonNode);
            allisonNode.AddOneWayAdjacent(maryNode);
            allisonNode.AddOneWayAdjacent(amyNode);
            amyNode.AddTwoWayAdjacent(robinNode);
            robinNode.AddTwoWayAdjacent(lauraNode);
            lauraNode.AddTwoWayAdjacent(janeNode);
            janeNode.AddOneWayAdjacent(harryNode);
            janeNode.AddOneWayAdjacent(bobNode);

            graph.Nodes.Append(jeffNode);
            graph.Nodes.Append(chrisNode);
            graph.Nodes.Append(disneyNode);
            graph.Nodes.Append(gingerNode);
            graph.Nodes.Append(emilyNode);
            graph.Nodes.Append(moeNode);
            graph.Nodes.Append(abbyNode);
            graph.Nodes.Append(amazonNode);
            graph.Nodes.Append(googleNode);
            graph.Nodes.Append(microsoftNode);
            graph.Nodes.Append(joeNode);
            graph.Nodes.Append(jacobNode);
            graph.Nodes.Append(bobNode);
            graph.Nodes.Append(janeNode);
            graph.Nodes.Append(harryNode);
            graph.Nodes.Append(lauraNode);
            graph.Nodes.Append(robinNode);
            graph.Nodes.Append(amyNode);
            graph.Nodes.Append(maryNode);
            graph.Nodes.Append(allisonNode);
            graph.Nodes.Append(danNode);
            graph.Nodes.Append(johnNode);
            graph.Nodes.Append(daleNode);

            return graph;
        }
    }
}
