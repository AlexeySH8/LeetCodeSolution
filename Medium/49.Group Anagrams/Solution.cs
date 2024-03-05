public class Solution
{
    private Dictionary<string, List<string>> dicAnagrams = new Dictionary<string, List<string>>();

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        foreach (string anagram in strs)
        {
            var key = new string (anagram
                .OrderBy(x => x)
                .ToArray());

            if (!dicAnagrams.ContainsKey(key))
                dicAnagrams.Add(key, new List<string>());

            dicAnagrams[key].Add(anagram);
        }

        return dicAnagrams
            .Select(x => (IList<string>)x.Value)
            .ToList();
    }
}