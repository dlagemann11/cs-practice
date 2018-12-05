using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures.Trees
{
    public class BinaryMinHeap<T> : BinaryTree<T> where T : IComparable
    {
        private BinaryTreeNode<T> NodeToAppend { get; set; }
        private int Count { get; set; }

        public BinaryMinHeap(T data) : base(data)
        {
            Count = 1;
        }

        public void Add(T data)
        {
            Count++;
            BinaryTreeNode<T> nodeToAdd = new BinaryTreeNode<T>(data);
            if (Count == 1)
            {
                Root = nodeToAdd;
            }
            else
            {
                string binaryString = Convert.ToString(Count, 2);
                AddToTree(Root, nodeToAdd, binaryString, 1);
                SiftUp(nodeToAdd);
            }
        }

        public T TakeMin()
        {
            T data = Root.Data;

            if (Count == 1)
            {
                Root = null;
            }
            else
            {
                string binaryString = Convert.ToString(Count, 2);
                BinaryTreeNode<T> removedNode = RemoveFromTree(Root, binaryString, 1);
                removedNode.Left = Root.Left;
                removedNode.Right = Root.Right;
                Root = removedNode;
                SiftDown(Root);
            }

            Count--;
            return data;
        }

        private void SiftUp(BinaryTreeNode<T> node)
        {
            if (node.Parent == null)
            {
                return;
            }

            int comparison = node.Data.CompareTo(node.Parent.Data);
            if (comparison < 0)
            {
                T tempData = node.Parent.Data;
                node.Parent.Data = node.Data;
                node.Data = tempData;               

                SiftUp(node.Parent);
            }
        }

        private void SiftDown(BinaryTreeNode<T> node)
        {
            if (node.Right == null && node.Left == null)
            {
                return;
            }

            BinaryTreeNode<T> nodeToCompare;
            if (node.Right == null && node.Left != null)
            {
                nodeToCompare = node.Left;                
            }
            else
            {
                int childComparison = node.Left.Data.CompareTo(node.Right.Data);
                if (childComparison < 0)
                {
                    nodeToCompare = node.Left;
                }
                else
                {
                    nodeToCompare = node.Right;
                }
            }

            int comparison = node.Data.CompareTo(nodeToCompare.Data);
            if (comparison > 0)
            {
                T tempData = nodeToCompare.Data;
                nodeToCompare.Data = node.Data;
                node.Data = tempData;

                SiftDown(nodeToCompare);
            }
        }

        private void AddToTree(BinaryTreeNode<T> node, BinaryTreeNode<T> nodeToAdd, string binaryStringPath, int index)
        {
            char thisBinary = binaryStringPath[index];
            if (index == binaryStringPath.Length - 1)
            {
                if (thisBinary == '0')
                {
                    node.Left = nodeToAdd;
                }
                else
                {
                    node.Right = nodeToAdd;
                }
                nodeToAdd.Parent = node;
            }
            else
            {
                index++;
                if (thisBinary == '0')
                {
                    AddToTree(node.Left, nodeToAdd, binaryStringPath, index);
                }
                else
                {
                    AddToTree(node.Right, nodeToAdd, binaryStringPath, index);
                }
            }
        }

        private BinaryTreeNode<T> RemoveFromTree(BinaryTreeNode<T> node, string binaryStringPath, int index)
        {
            char thisBinary = binaryStringPath[index];
            if (index == binaryStringPath.Length - 1)
            {
                BinaryTreeNode<T> nodeToRemove;
                if (thisBinary == '0')
                {
                    nodeToRemove = node.Left;
                    node.Left.Parent = null;
                    node.Left = null;
                }
                else
                {
                    nodeToRemove = node.Right;
                    node.Right.Parent = null;
                    node.Right = null;
                }
                return nodeToRemove;
            }
            else
            {
                index++;
                if (thisBinary == '0')
                {
                    return RemoveFromTree(node.Left, binaryStringPath, index);
                }
                else
                {
                    return RemoveFromTree(node.Right, binaryStringPath, index);
                }
            }
        }
    }
}
