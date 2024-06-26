﻿public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (numbers[left] + numbers[right] != target)
        {
           if(numbers[left] + numbers[right]<target)
                left++;
           else right--;
        }
        return new int[] { left, right };
    }
}