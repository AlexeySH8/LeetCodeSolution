public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int day = 0; day < temperatures.Length; day++)
        {
            while (stack.Count > 0 &&
                temperatures[day] > temperatures[stack.Peek()])
                result[stack.Peek()] = day - stack.Pop();

            stack.Push(day);
        }
        return result;
    }
}