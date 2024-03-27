public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;
        Array.Sort(nums);
        int length = 1;
        int temp = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1] - 1)
            {
                temp++;
                length = Math.Max(length, temp);
            }
            else if (nums[i] != nums[i + 1])
            {
                length = Math.Max(length, temp);
                temp = 1;
            }
        }
        return length;
    }
}