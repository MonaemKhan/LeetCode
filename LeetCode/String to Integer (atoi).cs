using System.Numerics;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(MyAtoi("  +  413"));
        Console.ReadKey();
    }
    public static int MyAtoi(string s)
    {
        char[] chars = s.ToCharArray();

        string sign = string.Empty;
        string intNum = string.Empty;

        foreach (char c in chars)
        {
            int num = Convert.ToInt32(c) - 48;
            if (string.IsNullOrEmpty(intNum) && string.IsNullOrEmpty(sign) && c == ' ')
            {
                continue;
            }
            else if (c == ' ')
            {
                break;
            }

            if (string.IsNullOrEmpty(intNum) && string.IsNullOrEmpty(sign) && (c == '-' || c == '+'))
            {
                sign = c + "";
                continue;
            }

            if (num >= 0 && num <= 9)
            {
                intNum = intNum + c;
            }
            else
            {
                break;
            }
        }

        if (string.IsNullOrEmpty(intNum))
        {
            return 0;
        }
        BigInteger bigValue = BigInteger.Parse(sign+intNum);

        int result;
        if (bigValue < int.MinValue)
            result = int.MinValue;
        else if (bigValue > int.MaxValue)
            result = int.MaxValue;
        else
            result = (int)bigValue;
        return result;
    }
}