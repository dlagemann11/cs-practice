using System;

using CsPractice.DataStructures.Trees;

namespace CsPractice.Problems.TreesAndGraphs
{
    public class TreeBalanceDetector<T>
    {
        private static readonly int UNBALANCED = Int32.MinValue;

        public bool IsBalanced(BinaryTree<T> tree)
        {
            return CheckDepth(tree.Root, 0) >= 0;
        }

        private int CheckDepth(BinaryTreeNode<T> node, int depth)
        {
            if (node == null)
            {
                return depth - 1;
            }

            int leftDepth = CheckDepth(node.Left, depth + 1);
            if (leftDepth == UNBALANCED)
            {
                return UNBALANCED;
            }
            int rightDepth = CheckDepth(node.Right, depth + 1);
            if (rightDepth == UNBALANCED)
            {
                return UNBALANCED;
            }

            if (Math.Abs(leftDepth - rightDepth) < 2)
            {
                return Math.Max(leftDepth, rightDepth);
            }
            else
            {
                return UNBALANCED;
            }
        }
    }
}
