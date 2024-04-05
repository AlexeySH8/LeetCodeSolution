public class MinStack
{
    private List<int> list;
    private Stack<int> minValue;
    public MinStack()
    {
        list = new List<int>();
        minValue = new Stack<int>();
    }

    public void Push(int val)
    {
        var temp = val;
        if (minValue.Count == 0 ||
            temp <= minValue.First())
            minValue.Push(temp);
        list.Add(val);
    }

    public void Pop()
    {
        if (list.Last() == minValue.First())
            minValue.Pop();
        list.RemoveAt(list.Count - 1);
    }

    public int Top()
    {
        return list.Last();
    }

    public int GetMin()
    {
        return minValue.First();
    }
}
