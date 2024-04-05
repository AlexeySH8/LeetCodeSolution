public class Solution
{
    private Stack<int> values = new Stack<int>();

    public int EvalRPN(string[] tokens)
    {
        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int vlaue))
                values.Push(vlaue);
            else
                values.Push(DoCalculation(values.Pop(),
                    values.Pop(), token));
        }
        return values.First();
    }

    private int DoCalculation(int b, int a, string operation) =>
        operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new Exception(operation)
        };

}