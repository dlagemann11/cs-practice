using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures.Trees
{
    public class TreeNode<T>
    {
        public ArrayList<TreeNode<T>> Children { get; }
        public T Data { get; }        

        public TreeNode(T data)
        {
            Data = data;
            Children = new ArrayList<TreeNode<T>>();
        }
    }
}
