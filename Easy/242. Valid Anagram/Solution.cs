public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        var dicS = MakeDictionary(s);
        var dicT = MakeDictionary(t);
        return AreDictionariesEqual(dicS, dicT);
    }

    static bool AreDictionariesEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        foreach (var key in dict1.Keys)
            if (!dict2.ContainsKey(key) || !dict2[key].Equals(dict1[key]))
                return false;
        return true;
    }

    private static Dictionary<char, int> MakeDictionary(string str)
    {
        var result = new Dictionary<char, int>();
        foreach (var chr in str)
        {
            if (result.ContainsKey(chr))
                result[chr]++;
            else result.Add(chr, 1);
        }
        return result;
    }
}