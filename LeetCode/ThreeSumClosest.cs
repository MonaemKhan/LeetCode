using System.Collections.Immutable;
using System.Numerics;
using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        //Console.WriteLine(ThreeSum([-1, 0, 1, 2, -1, -4]));
        //Console.WriteLine(ThreeSum([-4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0]));
        //Console.WriteLine(ThreeSum([0, 1, 1]));
        //Console.WriteLine(ThreeSum([0, 0, 0]));
        Console.WriteLine(ThreeSumClosest([1, 1, 1, 0],-100));
        Console.WriteLine(ThreeSumClosest([4, 0, 5, -5, 3, 3, 0, -4, -5],-2));
        Console.ReadKey();
    }

    public static int ThreeSumClosest(int[] nums, int target)
    {
        int len = nums.Length;
        Array.Sort(nums);
        int closest = nums[0] + nums[1] + nums[2];
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                for (int k = j + 1; k < len; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == target)
                    {
                        closest = sum;
                        break;
                    }
                    if (Math.Abs(sum - target) <= Math.Abs(closest - target) && Math.Abs(sum - target) != 0)
                    {
                        closest = sum;
                    }
                }
            }
        }
        return closest;
    }
}