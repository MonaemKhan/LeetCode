using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Median
    {
        public static void Main4(string[] args)
        {
            Console.WriteLine(FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }));
            Console.ReadKey();
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length = nums1.Length + nums2.Length;
            int[] joinArr = new int[length];
            for (int i = 0; i < nums1.Length; i++)
            {
                joinArr[i] = nums1[i];
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                joinArr[i + nums1.Length] = nums2[i];
            }

            Array.Sort(joinArr);

            if (length % 2 != 0)
            {
                return joinArr[(length - 1) / 2] * 1.0;
            }
            else
            {
                int n = (length) / 2;
                return ((joinArr[n] + joinArr[n - 1] * 1.0) / 2);
            }
        }
    }
}
