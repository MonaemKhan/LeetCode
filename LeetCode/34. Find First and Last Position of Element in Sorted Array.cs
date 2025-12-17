class TestClass
{
    
    static void Main(string[] args)
    {
        var re = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 },8);
        Console.WriteLine("Length: " + re);
        Console.ReadKey();
    }

    public static int[] SearchRange(int[] nums, int target)
    {
        int firstIndex = -1;
        int lastIndex = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                if (firstIndex == -1)
                {
                    firstIndex = i;                    
                }
                lastIndex = i;
            }
        }
        return new int[] { firstIndex,lastIndex};
    }

}