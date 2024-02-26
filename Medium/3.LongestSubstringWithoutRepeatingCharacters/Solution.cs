public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var list = new List<char>();
        int index = 0, max = 0;

        while (index < s.Length)
        {
            if (index < s.Length && !list.Contains(s[index]))
            {
                list.Add(s[index++]);
                if (list.Count > max)
                    max = list.Count;
            }
            else
                list.RemoveAt(0);
        }
        return max;
    }
}