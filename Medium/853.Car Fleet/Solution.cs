public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        Array.Sort(position, speed);
        var stack = new Stack<float>();
        for (int car = 0; car < position.Length; car++)
        {
            var time = (float)(target - position[car]) / speed[car];
            while (stack.Count > 0 && stack.Peek() <= time)
                stack.Pop();
            stack.Push(time);
        }
        return stack.Count;
    }
}