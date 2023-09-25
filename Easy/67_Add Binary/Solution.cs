using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var charArray = new char[Math.Max(a.Length, b.Length) + 1];
        int indexA = a.Length - 1;
        int indexB = b.Length - 1;
        int carry = 0;
        byte numA = 0;
        byte numB = 0;
        for (int i = 0; i < charArray.Length; i++)
        {
            if (indexA < 0 && indexB < 0)
            {
                if (carry == 1) charArray[charArray.Length - 1] = '1';
                else charArray[charArray.Length - 1] = '0';
                break;
            }

            numA = (byte)((indexA >= 0) ? (byte)(a[indexA--] - '0') : 0);

            numB = (byte)((indexB >= 0) ? (byte)(b[indexB--] - '0') : 0);

            var solution = SummingBinaryNum(numA, numB, carry);
            indexA--;
            indexB--;
            char resultOfSum = solution.result;
            carry = solution.carry;
            charArray[i] = resultOfSum;
        }
        return MakeString(charArray);
    }

    public string MakeString(char[] array)
    {
        var builder = new StringBuilder();
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == array.Length - 1 && array[i] == '0')
            {
                continue;
            }
            builder.Append(array[i]);
        }
        return builder.ToString();
    }

    public (char result, int carry) SummingBinaryNum(byte numA, byte numB, int overcup)
    {
        int sum = numA + numB + overcup;
        switch (sum)
        {
            case 3:
                return ('1', 1);
            case 2:
                return ('0', 1);
            case 1:
                return ('1', 0);
            case 0:
                return ('0', 0);
            default: return ('0', 0);
        }
    }
}


