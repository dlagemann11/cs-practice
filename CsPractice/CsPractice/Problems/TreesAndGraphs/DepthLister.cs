using CsPractice.DataStructures;
using CsPractice.DataStructures.Trees;

namespace CsPractice.Problems.TreesAndGraphs
{
    public class DepthLister
    {
        public ArrayList<SingleLinkNode<T>> BinaryTreeToLinkedLists<T>(BinaryTree<T> tree)
        {
            ArrayList<SingleLinkNode<T>> linkedLists = new ArrayList<SingleLinkNode<T>>();
            Traverse(tree.Root, 0, linkedLists);
            return linkedLists;
        }

        private void Traverse<T>(BinaryTreeNode<T> treeNode, int depth, ArrayList<SingleLinkNode<T>> linkedLists)
        {
            if (treeNode == null)
            {
                return;
            }

            SingleLinkNode<T> linkNode = new SingleLinkNode<T>(treeNode.Data);
            if (depth >= linkedLists.Count)
            {
                linkedLists.Append(linkNode);
            }
            else
            {
                linkNode.Next = linkedLists[depth];
                linkedLists[depth] = linkNode;
            }

            Traverse(treeNode.Left, depth + 1, linkedLists);
            Traverse(treeNode.Right, depth + 1, linkedLists);
        }
    }
}
