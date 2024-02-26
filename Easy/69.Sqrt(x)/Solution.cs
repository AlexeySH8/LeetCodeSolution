public class Solution
{
    public int MySqrt(int num)
    {
        if (num == 0) return 0;
        if (num == 1) return 1;
        double x = num / 2;
        int stop = 0;
        while (x * x != num)
        {
            x = (x + (num / x)) / 2;
            if (stop == Math.Floor(x))
                return (int)x;
            stop = (int)x;
        }
        return (int)x;
    }
}