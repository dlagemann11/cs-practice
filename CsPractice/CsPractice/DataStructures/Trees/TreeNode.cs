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
