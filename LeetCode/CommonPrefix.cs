using System.Numerics;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        //Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
        //Console.WriteLine(LongestCommonPrefix(["dog", "racecar", "car"]));
        //Console.WriteLine(LongestCommonPrefix(["reflower", "flow", "flight"]));
        //Console.WriteLine(LongestCommonPrefix([""]));
        //Console.WriteLine(LongestCommonPrefix(["c", "acc", "ccc"]));
        Console.WriteLine(LongestCommonPrefix(["", ""]));
        Console.ReadKey();
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        string prefix = "";
        int startIndex = 0;
        int length = 0;
        int strLen = strs.Length;
        if(strLen == 0)
        {
            return "";
        }
        if (strLen == 1)
        {
            return strs[0];
        }
        if (strs[0] == "")
        {
            return prefix;
        }
        int num = 0;
        while (true)
        {

            length = length + 1;
            string p = strs[0].Substring(startIndex, length);
            num = 0;
            for (int i = 1; i < strLen; i++)
            {
                try
                {
                    if (strs[i].Substring(startIndex, length) == p)
                    {
                        num = num + 1;
                    }
                }
                catch
                {

                }
                if (num == strLen - 1)
                {
                    if (prefix.Length < p.Length)
                    {
                        prefix = p;
                    }
                }
            }
            
            if ((length+startIndex) == strs[0].Length)
            {
                break;
            }
        }

        return prefix;
    }
}