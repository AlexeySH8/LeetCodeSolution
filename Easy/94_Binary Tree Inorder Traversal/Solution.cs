using Class_Work;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        if (root != null)
        {
            if (root.left != null)
            {
                list.AddRange(InorderTraversal(root.left));
            }
            list.Add(root.val);
            if (root.right != null)
            {
                list.AddRange(InorderTraversal(root.right));
            }
        }
        return list;
    }
}
