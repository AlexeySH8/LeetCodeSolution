public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        var stack = new Stack<TreeNode>();
        var current = root;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();
            list.Add(current.val);
            current = current.right;
        }
        return list;
    }
}