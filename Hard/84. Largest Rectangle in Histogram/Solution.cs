public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int max = 0;
        var stack = new Stack<int>();
        for (int i = 0; i <= heights.Length; i++)
        {
            int h = (i == heights.Length) ? 0 : heights[i];

            if (stack.Count == 0 || h >= heights[stack.Peek()])
                stack.Push(i);
            else
            {
                while (stack.Count != 0 && h < heights[stack.Peek()])
                {
                    var length = heights[stack.Pop()];
                    int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                    var temp = width * length;
                    max = Math.Max(max, temp);
                }
                stack.Push(i);
            }
        }
        return max;
    }
}