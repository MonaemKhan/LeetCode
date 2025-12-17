class TestClass
{
    
    static void Main(string[] args)
    {
        var re = SearchInsert(new int[] { 1, 3, 5, 6 },5);
        Console.WriteLine("Length: " + re);
        Console.ReadKey();
    }

    public static int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
            {
                return i;
            }
        }
        return nums.Length;
    }

}