using CsPractice.DataStructures.Trees;

namespace CsPractice.Problems.TreesAndGraphs
{
    public class BstValidater
    {
        public bool Validate(BinaryTreeNode<int> root)
        {
            return TraverseAndValidate(root, int.MinValue, int.MaxValue);
        }

        private bool TraverseAndValidate(BinaryTreeNode<int> node, int min, int max)
        {
            if (node.Data < min || node.Data > max)
            {
                return false;
            }

            if (node.Left != null)
            {
                if (!TraverseAndValidate(node.Left, min, node.Data))
                {
                    return false;
                }
            }

            if (node.Right != null)
            {
                return TraverseAndValidate(node.Right, node.Data, max);
            }

            return true;
        }
    }
}
