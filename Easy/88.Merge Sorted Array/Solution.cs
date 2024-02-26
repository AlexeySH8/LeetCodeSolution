public class Solution
{
    public void Merge(int[] basik, int basikIndex, int[] sub, int subIndex)
    {
        for (int i = basik.Length - 1; i >= 0; i--)
        {
            if ((subIndex <= 0) ||
                (basikIndex > 0 && basik[basikIndex - 1] > sub[subIndex - 1]))
            {
                basik[i] = basik[basikIndex - 1];
                basikIndex--;
            }
            else
            {
                basik[i] = sub[subIndex - 1];
                subIndex--;
            }
        }
    }
}