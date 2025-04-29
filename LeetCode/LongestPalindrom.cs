using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestPalindrom
    {
        public static void Main5(string[] args)
        {
            Console.WriteLine(LongestPalindrome("abcdbbfcba"));
            Console.ReadKey();
        }
        public static string LongestPalindrome(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            if (s == reversed)
            {
                return s;
            }

            int maxPalindrom = 0;
            string maxPalindromText = "";

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {
                    string str = s.Substring(i, j);
                    char[] ar = str.ToCharArray();
                    Array.Reverse(ar);
                    string rev = new string(ar);
                    if (str == rev)
                    {
                        if (str.Length > maxPalindrom)
                        {
                            maxPalindrom = str.Length;
                            maxPalindromText = str;
                        }
                    }
                }
            }

            return maxPalindromText;
        }
    }
}
