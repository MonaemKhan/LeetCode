using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverceInteger
    {
        public static void Main7(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
            Console.ReadKey();
        }

        public static int Reverse(int x)
        {
            string returnVal = "";
            if (x > 0)
            {
                char[] arr = x.ToString().ToCharArray();
                Array.Reverse(arr);
                foreach (var a in arr)
                {
                    returnVal = returnVal + a;
                }
                bool isSuccess = Int32.TryParse(returnVal, out int reversedInt);
                if (!isSuccess)
                    return 0;

                return Convert.ToInt32(returnVal);
            }
            else
            {
                char[] arr = (x * -1).ToString().ToCharArray();
                Array.Reverse(arr);
                foreach (var a in arr)
                {
                    returnVal = returnVal + a;
                }
                bool isSuccess = Int32.TryParse(returnVal, out int reversedInt);
                if (!isSuccess)
                    return 0;

                return (Convert.ToInt32(returnVal) * -1);
            }
        }
    }
}
