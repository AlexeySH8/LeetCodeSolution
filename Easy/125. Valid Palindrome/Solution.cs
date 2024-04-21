using System.Text.RegularExpressions;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s.Length == 1) return true;
        s = RemoveNonAlphabeticCharacters(s).ToLower();
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    private string RemoveNonAlphabeticCharacters(string s)
    {
        return Regex.Replace(s, @"[^\p{L}\p{N}]", "");
    }
}