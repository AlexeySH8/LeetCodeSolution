public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int result = 0, temp = 0;

        while (left < right)
        {
            temp = (right - left) * Math.Min(height[left], height[right]);

            if (height[right] > height[left])
                left++;
            else
                right--;
            result = Math.Max(result, temp);
        }
        return result;
    }
}