public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var values = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var deltaNum = target - nums[i];
            if (values.ContainsKey(deltaNum))
                return new int[] { values[deltaNum], i };
            values.TryAdd(nums[i], i);
        }
        return default;
    }
}