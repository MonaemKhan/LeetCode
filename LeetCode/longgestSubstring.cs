using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class longgestSubstring
    {
        public static void Main3(string[] args)
        {
            string s = "";
            Console.WriteLine(LengthOfLongestSubstring(s));
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                int subStringLength = 1;
                char[] charArr = s.ToCharArray();
                List<char> container = new List<char>();

                for (int i = 0; i < charArr.Length - 1; i++)
                {
                    List<char> duplicate = new List<char>();
                    duplicate.Add(charArr[i]);
                    for (int j = i + 1; j < charArr.Length; j++)
                    {
                        if (duplicate.Contains(charArr[j]))
                        {
                            break;
                        }
                        else
                        {
                            duplicate.Add(charArr[j]);
                        }
                    }
                    if (duplicate.Count() > subStringLength)
                    {
                        subStringLength = duplicate.Count();
                    }
                }

                return subStringLength;
            }
            return 0;
        }
    }
}
