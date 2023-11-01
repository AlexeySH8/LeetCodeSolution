using System;
using System.Text;

public class Solution
{
    private new List<string> result = new List<string>();
    private static Dictionary<char, string> LettersInNum = new Dictionary<char, string>
    {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (digits == null || digits.Length == 0) return new List<string>();
        MakePermutation(digits, 0, new StringBuilder());
        return result;
    }

    public void MakePermutation(string digits, int indexOfKey,
        StringBuilder builder)
    {
        if (indexOfKey > digits.Length - 1)
        {
            result.Add(builder.ToString());
            return;
        }

        foreach (char currentLetter in LettersInNum[digits[indexOfKey]])
        {
            builder.Append(currentLetter);
            MakePermutation(digits, indexOfKey + 1, builder);
            builder.Remove(builder.Length - 1, 1);
        }
    }
}