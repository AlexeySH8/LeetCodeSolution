public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int length = nums.Length;
        var result = new int[length];
        int sufix = 1;
        result[0] = 1;

        for (int i = 1; i < length; i++)
            result[i] = result[i - 1] * nums[i - 1];

        for (int i = length - 1; i >= 0; i--)
        {
            result[i] *= sufix;
            sufix *= nums[i];
        }
        return result;
    }
}