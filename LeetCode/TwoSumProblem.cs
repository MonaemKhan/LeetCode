using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TwoSumProblem
    {
        public static void main1(string[] args)
        {
            int[] nums = new int[] { 3, 3 };
            int[] sumIndex = TwoSum(nums, 6);
            string result = "[";
            for (int i = 0; i < sumIndex.Length; i++)
            {
                result = result + sumIndex[i];
                if (i != sumIndex.Length - 1)
                {
                    result = result + ",";
                }
            }
            result = result + "]";

            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] sumIndex = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] sumindex = { i, j };
                        sumIndex = sumindex;
                        break;
                    }
                }
            }

            return sumIndex;
        }
    }
}
