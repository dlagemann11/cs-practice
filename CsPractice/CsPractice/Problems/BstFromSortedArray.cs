
using CsPractice.DataStructures.Trees;

namespace CsPractice.Problems
{
    public class BstFromSortedArray
    {
        public BinarySearchTree<int> CreateBinarySearchTree(int[] sortedArray)
        {
            // Needs efficiency increase: Currently O(N logN) since each insertion requires traversal.
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            CreateTreeHelper(tree, sortedArray, 0, sortedArray.Length - 1);
            return tree;
        }

        private void CreateTreeHelper(BinarySearchTree<int> tree, int[] sortedArray, int leftIndex, int rightIndex)
        {
            int midPoint = leftIndex + (((rightIndex - leftIndex) / 2) + (rightIndex - leftIndex) % 2);
            tree.Add(sortedArray[midPoint]);
            if (leftIndex < midPoint)
            {
                CreateTreeHelper(tree, sortedArray, leftIndex, midPoint - 1);
            }
            if (rightIndex > midPoint)
            {
                CreateTreeHelper(tree, sortedArray, midPoint + 1, rightIndex);
            }
        }
    }
}
