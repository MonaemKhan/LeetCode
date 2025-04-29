using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ZigzacConverstion
    {
        public static void Main6(string[] args)
        {
            Console.WriteLine(Convert("AB", 1));
            Console.ReadKey();
        }

        public static string Convert(string s, int numRows)
        {
            if (numRows < 2)
            {
                return s;
            }
            string[] str = new string[numRows];
            char[] arr = s.ToCharArray();
            int current = 0;
            bool flag = true;
            foreach (char c in arr)
            {
                str[current] = "" + str[current] + c;
                if (flag)
                    current++;
                else
                    current--;

                if (current == 0)
                {
                    flag = true;
                }
                if (current == (numRows - 1))
                {
                    flag = false;
                }
            }

            string sr = "";
            foreach (var a in str)
            {
                sr = sr + a;
            }

            return sr;

        }
    }
}
