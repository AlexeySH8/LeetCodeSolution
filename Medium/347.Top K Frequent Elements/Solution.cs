public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var result = new int[k];
        var queue = new PriorityQueue<int, int>();
        var dict = nums
            .GroupBy(x => x)
            .ToDictionary(group => group.Key, group => group.Count());

        foreach (var item in dict)
            queue.Enqueue(item.Key, -item.Value);

        for (int i = 0; i < k; i++)
            result[i] = queue.Dequeue();

        return result;
    }
}