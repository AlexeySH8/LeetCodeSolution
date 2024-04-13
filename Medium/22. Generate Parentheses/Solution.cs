public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        GenerateParenthesisList(list, "", 0, 0, n);
        return list;
    }

    private void GenerateParenthesisList(List<string> result,
        string current, int open, int close, int max)
    {
        if (current.Length == max * 2)
        {
            result.Add(current);
            return;
        }

        if (open < max)
            GenerateParenthesisList(result, current + "(", open + 1, close, max);


        if (close < open)
            GenerateParenthesisList(result, current + ")", open, close + 1, max);
    }
}