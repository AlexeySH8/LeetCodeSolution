public class Solution
{
    public int Trap(int[] height)
    {
        int water = 0;
        int left = 0;
        int right = height.Length - 1;
        int maxLeft = height[left];
        int maxRight = height[right];

        while (left < right - 1)
        {
            if (height[left] < height[right])
            {
                left++;
                if (height[left] < maxLeft)
                {
                    water += maxLeft - height[left];
                }
                else maxLeft = height[left];
            }
            else
            {
                right--;
                if (height[right] < maxRight)
                {
                    water += maxRight - height[right];
                }
                else maxRight = height[right];
            }
        }
        return water;
    }
}