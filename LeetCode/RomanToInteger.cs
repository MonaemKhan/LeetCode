using System.Numerics;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        //Console.WriteLine(RomanToInt("III"));
        //Console.WriteLine(RomanToInt("LVIII"));
        Console.WriteLine(RomanToInt("MCMXCIV"));
        Console.ReadKey();
    }

    public static int RomanToInt(string s)
    {
        int number = 0;
        string[] chars = s.Select(c=>c.ToString()).ToArray();
        int i = 0;
        while (i < chars.Length)
        {
            string str = "";
            try
            {
                str = chars[i] + chars[i + 1] + "";
            }
            catch
            {
                str = chars[i] + "";
            }
            switch (str)
            {
                case "IV":
                    number = number + 4;
                    i = i + 2;
                    break;
                case "IX":
                    number = number + 9;
                    i = i + 2;
                    break;
                case "XL":
                    number = number + 40;
                    i = i + 2;
                    break;
                case "XC":
                    number = number + 90;
                    i = i + 2;
                    break;
                case "CD":
                    number = number + 400;
                    i = i + 2;
                    break;
                case "CM":
                    number = number + 900;
                    i = i + 2;
                    break;
                default:
                    switch (chars[i])
                    {
                        case "I":
                            number = number + 1;
                            i = i + 1;
                            break;
                        case "V":
                            number = number + 5;
                            i = i + 1;
                            break;
                        case "X":
                            number = number + 10;
                            i = i + 1;
                            break;
                        case "L":
                            number = number + 50;
                            i = i + 1;
                            break;
                        case "C":
                            number = number + 100;
                            i = i + 1;
                            break;
                        case "D":
                            number = number + 500;
                            i = i + 1;
                            break;
                        case "M":
                            number = number + 1000;
                            i = i + 1;
                            break;
                        default:
                            number = number + 0;
                            i = i + 1;
                            break;
                    }
                    break;
            }
        }

        return number;
    }


}