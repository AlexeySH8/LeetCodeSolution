public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var leftRow = 0;
        var rightRow = matrix.Length - 1;
        while (leftRow <= rightRow)
        {
            var mid = (leftRow + rightRow) / 2;
            var row = matrix[mid];
            if (target >= row[0] && target <= row[row.Length - 1])
                return IsValueInRow(row, target);
            else if (target > row[row.Length - 1])
                leftRow = mid + 1;
            else
                rightRow = mid - 1;
        }
        return false;
    }

    private bool IsValueInRow(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
                return true;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}