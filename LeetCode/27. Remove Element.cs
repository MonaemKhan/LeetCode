public int RemoveElement(int[] nums, int val) {
        int count = 0;
//List<int> list = new List<int>();
foreach (var num in nums)
{
    if (num != val)
    {        
        nums[count] = num;
        count = count + 1;
        //list.Add(num);
    }
}

//nums = list.ToArray();
return count;
    }