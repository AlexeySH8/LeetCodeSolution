public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var temp = nums.OrderBy(x => x).ToArray();
        Array.Sort(temp);
        var result = new List<IList<int>>();
        for (int i = 0; i < temp.Length - 2; i++)
        {
            if (i > 0 && temp[i] == temp[i - 1])
                continue;

            int left = i + 1;
            int right = temp.Length - 1;
            while (left < right)
            {
                var sum = temp[i] + temp[left] + temp[right];
                if (sum == 0)
                {
                    result.Add(new List<int>() { temp[i], temp[left], temp[right] });
                    while (left < right && temp[left] == temp[left + 1])
                        left++;
                    left++;
                }
                else if (sum > 0) right--;
                else left++;
            }
        }
        return result;
    }
}