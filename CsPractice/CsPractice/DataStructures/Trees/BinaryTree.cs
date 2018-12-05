namespace CsPractice.DataStructures.Trees
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree()
        {
        }

        public BinaryTree(T data)
        {
            Root = new BinaryTreeNode<T>(data);
        }

        public ArrayList<T> InOrderTraversal()
        {
            ArrayList<T> visitedNodes = new ArrayList<T>();
            InOrderTraverse(Root, visitedNodes);
            return visitedNodes;
        }

        public ArrayList<T> PreOrderTraversal()
        {
            ArrayList<T> visitedNodes = new ArrayList<T>();
            PreOrderTraverse(Root, visitedNodes);
            return visitedNodes;
        }

        public ArrayList<T> PostOrderTraversal()
        {
            ArrayList<T> visitedNodes = new ArrayList<T>();
            PostOrderTraverse(Root, visitedNodes);
            return visitedNodes;
        }

        private void InOrderTraverse(BinaryTreeNode<T> node, ArrayList<T> visitedNodes)
        {
            if (node == null)
            {
                return;
            }
            InOrderTraverse(node.Left, visitedNodes);
            visitedNodes.Append(node.Data);
            InOrderTraverse(node.Right, visitedNodes);
        }

        private void PreOrderTraverse(BinaryTreeNode<T> node, ArrayList<T> visitedNodes)
        {
            if (node == null)
            {
                return;
            }            
            visitedNodes.Append(node.Data);
            PreOrderTraverse(node.Left, visitedNodes);
            PreOrderTraverse(node.Right, visitedNodes);
        }

        private void PostOrderTraverse(BinaryTreeNode<T> node, ArrayList<T> visitedNodes)
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraverse(node.Left, visitedNodes);
            PostOrderTraverse(node.Right, visitedNodes);
            visitedNodes.Append(node.Data);
        }
    }
}
