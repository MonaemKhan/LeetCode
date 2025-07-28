using System.Numerics;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(IntToRoman(3749));
        Console.WriteLine(IntToRoman(58));
        Console.WriteLine(IntToRoman(1994));
        Console.WriteLine(IntToRoman(9999));
        Console.ReadKey();
    }
    public static string IntToRoman(int num)
    {
        string roman = "";
        int remain = 0;
        int sub = 0;
        switch (num)
        {
            case int n when n >= 1000:
                sub = n / 1000;
                remain = n % 1000;
                while(sub > 0)
                {
                    roman = roman + "M";
                    sub = sub-1;
                }
                switch (remain) {
                    case int i when i>0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 900:
                sub = n / 900;
                remain = n % 900;
                while (sub > 0)
                {
                    roman = roman + "CM";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 500:
                sub = n / 500;
                remain = n % 500;
                while (sub > 0)
                {
                    roman = roman + "D";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 400:
                sub = n / 400;
                remain = n % 400;
                while (sub > 0)
                {
                    roman = roman + "CD";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 100:
                sub = n / 100;
                remain = n % 100;
                while (sub > 0)
                {
                    roman = roman + "C";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 90:
                sub = n / 90;
                remain = n % 90;
                while (sub > 0)
                {
                    roman = roman + "XC";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 50:
                sub = n / 50;
                remain = n % 50;
                while (sub > 0)
                {
                    roman = roman + "L";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 40:
                sub = n / 40;
                remain = n % 40;
                while (sub > 0)
                {
                    roman = roman + "XL";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 10:
                sub = n / 10;
                remain = n % 10;
                while (sub > 0)
                {
                    roman = roman + "X";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 9:
                sub = n / 9;
                remain = n % 9;
                while (sub > 0)
                {
                    roman = roman + "IX";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 5:
                sub = n / 5;
                remain = n % 5;
                while (sub > 0)
                {
                    roman = roman + "V";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            case int n when n >= 4:
                sub = n / 4;
                remain = n % 4;
                while (sub > 0)
                {
                    roman = roman + "IV";
                    sub = sub - 1;
                }
                switch (remain)
                {
                    case int i when i > 0:
                        return roman + IntToRoman(remain);
                    default:
                        return roman;
                }
            default:
                while(num > 0)
                {
                    roman = roman + "I";
                    num = num - 1;
                }
                return roman;
        }



    }
}