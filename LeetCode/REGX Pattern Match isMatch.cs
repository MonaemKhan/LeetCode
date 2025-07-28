using System.Numerics;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsMatch("aa","a"));
        Console.ReadKey();
    }
    public static bool IsMatch(string s, string p)
    {
        bool isMatch = Regex.IsMatch(s,"^"+ p+"$");
        return isMatch;
    }
}