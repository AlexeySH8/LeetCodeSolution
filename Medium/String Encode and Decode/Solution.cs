using System.Text;

public class Solution
{
    public string Encode(IList<string> strs)
    {
        var builder = new StringBuilder();
        foreach (var str in strs)
            builder.Append(str.Length).Append('/').Append(str);
        return builder.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int index = 0;
        while (index < s.Length)
        {
            int slashIndex = s.IndexOf("/", index);
            int subStringLength = int.Parse(s.Substring(index, slashIndex - index));
            result.Add(s.Substring(slashIndex + 1, subStringLength));
            index = slashIndex + subStringLength + 1;
        }
        return result;
    }
}
