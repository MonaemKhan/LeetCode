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
        Console.WriteLine(ThreeSum([0, 3, 0, 1, 1, -1, -5, -5, 3, -3, -3, 0]));
        Console.ReadKey();
    }

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> triplates = new List<IList<int>>();
        IList<int> ints = new List<int>();
        int len = nums.Length;
        bool isAdd = true;
        int lenofI = len;
        if(nums.Length > 100)
        {
            lenofI = len/2;
        }
        for (int i = 0; i < lenofI; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                for (int k = j + 1; k < len; k++)
                {
                    if (i != j && i != k && j != k)
                    {
                        if(i==2 && j == 3&& k== 5)
                        {

                        }
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            if (nums[i] <= nums[j] && nums[i] <= nums[k])
                            {
                                ints.Add(nums[i]);
                                if (nums[j] <= nums[k])
                                {
                                    ints.Add(nums[j]);
                                    ints.Add(nums[k]);
                                }
                                else
                                {
                                    ints.Add(nums[k]);
                                    ints.Add(nums[j]);
                                }
                            }
                            else if (nums[j] <= nums[i] && nums[j] <= nums[k])
                            {
                                ints.Add(nums[j]);
                                if (nums[i] <= nums[k])
                                {
                                    ints.Add(nums[i]);
                                    ints.Add(nums[k]);
                                }
                                else
                                {
                                    ints.Add(nums[k]);
                                    ints.Add(nums[i]);
                                }
                            }
                            else
                            {
                                ints.Add(nums[k]);
                                if (nums[i] <= nums[j])
                                {
                                    ints.Add(nums[i]);
                                    ints.Add(nums[j]);
                                }
                                else
                                {
                                    ints.Add(nums[j]);
                                    ints.Add(nums[i]);
                                }
                            }
                            isAdd = true;
                            foreach (var obj in triplates)
                            {
                                if (obj[0] == ints[0]
                                    && obj[1] == ints[1]
                                    && obj[2] == ints[2])
                                {
                                    isAdd = false;
                                    break;
                                }
                            }
                            if (isAdd)
                            {
                                triplates.Add(ints);
                            }
                            ints = new List<int>();

                        }
                    }
                }
            }
        }

        for (int i = 0; i < triplates.Count; i++)
        {
            for (int j = i + 1; j < triplates.Count; j++)
            {
                if (triplates[i][0] >= triplates[j][0])
                {
                    var temp = triplates[i];
                    triplates[i] = triplates[j];
                    triplates[j] = temp;
                }
            }
        }

        return triplates;
    }
}