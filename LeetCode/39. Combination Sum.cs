using System.Text;

class TestClass
{
    
    static void Main(string[] args)
    {
        TestClass testClass = new TestClass();
        
        var stopwatch = new System.Diagnostics.Stopwatch();
        long timeElapsed = 0;
        for (int i = 1; i <= 30; i++)
        {
            stopwatch.Start();
            string result = testClass.CountAndSay(i);
            stopwatch.Stop();            
            Console.WriteLine($"n={i}, Time={stopwatch.ElapsedMilliseconds}ms, Result={result}");
            timeElapsed += stopwatch.ElapsedMilliseconds;
            stopwatch.Reset();
        }
        Console.WriteLine($"Total Time Elapsed: {timeElapsed}ms");
        Console.WriteLine($"Average Time Elapsed: {timeElapsed/30}ms");
        Console.ReadKey();
    }

    public string CountAndSay(int n)
    {
        if (n == 0)
        {
            return "";
        }else if (n == 1)
        {
            return "1";
        }
        string say = "1";
        for (int i = 1; i < n; i++)
        {
            say = GetNextSequence(i+1,say);
        }
        return say;
    }

    public string GetNextSequence(int count,string say)
    {
        string tempSay = say;
        string newSay = "";
        int consecutiveCount = 0;
        if (say.Length > 1)
        {
            for (int i = 0; i < tempSay.Length; i++)
            {
                consecutiveCount++;
                try
                {
                    if (tempSay[i] != tempSay[i + 1])
                    {
                        newSay += consecutiveCount.ToString() + tempSay[i];
                        consecutiveCount = 0;
                    }
                }
                catch (Exception ex)
                {
                    newSay += consecutiveCount.ToString() + tempSay[i];
                    consecutiveCount = 0;
                }
            }
        }
        else
        {
            newSay = "11";
            return newSay;
        }

        return newSay;
    }

}