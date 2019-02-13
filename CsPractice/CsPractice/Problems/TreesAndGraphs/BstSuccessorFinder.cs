using CsPractice.DataStructures.Trees;

namespace CsPractice.Problems.TreesAndGraphs
{
    public class BstSuccessorFinder
    {
        public BinaryTreeNode<int> GetSuccessor(BinaryTreeNode<int> node)
        {
            if (node.Right != null)
            {
                node = node.Right;
                while (node.Left != null)
                {
                    node = node.Left;
                }
                return node;
            }

            while (node.Parent != null)
            {
                BinaryTreeNode<int> parentNode = node.Parent;
                if (parentNode.Left == node)
                {
                    return parentNode;
                }
                node = parentNode;
            }

            return null;
        }
    }
}
