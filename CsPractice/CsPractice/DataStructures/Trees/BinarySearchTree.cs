using System;

namespace CsPractice.DataStructures.Trees
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        public BinarySearchTree() : base() { }

        public BinarySearchTree(T data) : base(data) { }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(data);
                return;
            }

            BinaryTreeNode<T> node = Find(Root, data);
            int comparison = data.CompareTo(node.Data);
            if (comparison == 0)
            {
                throw new AlreadyExistsException();
            }
            else if (comparison < 0)
            {
                node.Left = new BinaryTreeNode<T>(data);
            }
            else
            {
                node.Right = new BinaryTreeNode<T>(data);
            }
        }

        public BinaryTreeNode<T> Get(T data)
        {
            BinaryTreeNode<T> node = Find(Root, data);
            int comparison = data.CompareTo(node.Data);
            if (comparison == 0)
            {
                return node;
            }
            else
            {
                throw new NotFoundException();
            }
        }

        private BinaryTreeNode<T> Find(BinaryTreeNode<T> node, T data)
        {
            int comparison = data.CompareTo(node.Data);
            if (comparison == 0)
            {
                return node;
            }
            else if (comparison < 0)
            {
                if (node.Left == null)
                {
                    return node;
                }
                else
                {
                    return Find(node.Left, data);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    return node;
                }
                else
                {
                    return Find(node.Right, data);
                }
            }
        }
    }

    public class AlreadyExistsException : Exception {}
    public class NotFoundException : Exception {}
}
