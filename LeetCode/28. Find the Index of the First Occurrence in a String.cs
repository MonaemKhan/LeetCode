class TestClass
{
    
    static void Main(string[] args)
    {
        var re = StrStr("3aaa3", "aaa");
        Console.WriteLine("Length: " + re);
        Console.ReadKey();
    }

    public static int StrStr(string haystack, string needle)
    {
        var haysArr = haystack.ToCharArray();
        var needArr = needle.ToCharArray();

        int currentIndex = 0;
        int i = 0;
        int j = 0;
        int TotalIterations = haysArr.Length - needle.Length + 1;

        while (currentIndex < TotalIterations)
        {
            if (haysArr[i] == needArr[j])
            {
                if(j == needArr.Length - 1)
                {
                    return currentIndex;
                }
                i = i + 1;
                j = j + 1;
            }
            else
            {
                currentIndex = currentIndex + 1;
                i = currentIndex;
                j = 0;
            }
        }

        return -1;
    }
}