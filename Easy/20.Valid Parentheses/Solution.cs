public class Solution
{
    private Dictionary<char, char> pair = new Dictionary<char, char>()
    {
        {'(' , ')' },
        {'[' , ']'},
        {'{' , '}'}
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var item in s)
        {
            if (pair.ContainsKey(item))
                stack.Push(item);
            else
            {
                if (stack.Count < 1 ||
                    !(pair[stack.Pop()] == item))
                    return false;
            }
        }
        return stack.Count == 0;
    }
}