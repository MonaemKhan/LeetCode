using System.Collections.Immutable;
using System.Numerics;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(LetterCombinations(""));
        Console.ReadKey();
    }

    public static IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, List<string>> myDict = new Dictionary<char, List<string>>();
        myDict['2'] = new List<string> { "a", "b" , "c" };
        myDict['3'] = new List<string> { "d", "e" , "f"};
        myDict['4'] = new List<string> { "g", "h" , "i"};
        myDict['5'] = new List<string> { "j", "k" , "l"};
        myDict['6'] = new List<string> { "m", "n" , "o"};
        myDict['7'] = new List<string> { "p", "q" , "r" , "s"};
        myDict['8'] = new List<string> { "t", "u" , "v"};
        myDict['9'] = new List<string> { "w", "x" , "y" , "z"};

        IList<string> temp = new List<string>();
        IList<string> final = new List<string>();

        var str = digits.ToArray();

        foreach (var digit in str)
        {
            foreach (var obj in myDict[digit])
            {
                if (final.Count <= 0)
                {
                    temp.Add(obj);
                }
                else
                {
                    foreach (var item in final)
                    {
                        temp.Add(item + obj);
                    }
                }
            }
            final = temp;
            temp = new List<string>();
        }

        return final;
    }
}