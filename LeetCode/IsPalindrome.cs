using System.Numerics;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(121));
        Console.ReadKey();
    }
    public static bool IsPalindrome(int x)
    {
        string s = x.ToString();
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);

        string rs = new string(chars);

        if(s == rs)
        {
            return true;
        }

        return false;
    }
}