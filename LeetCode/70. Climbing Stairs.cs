using System.Diagnostics;
using System.Numerics;
using System.Text;

class TestClass
{

    static async Task Main(string[] args)
    {
        TestClass tc = new TestClass();
        Stopwatch sw = Stopwatch.StartNew();
        //Console.WriteLine(tc.ClimbStairs(2));
        //Console.WriteLine(tc.ClimbStairs(3));
        Console.WriteLine(tc.ClimbStairs(4));
        Console.WriteLine(tc.ClimbStairs(5));
        Console.WriteLine(tc.ClimbStairs(6));
        sw.Stop();

        // 4. Output results
        Console.WriteLine($"Elapsed Milliseconds: {sw.ElapsedMilliseconds}ms");
        Console.WriteLine($"Total Elapsed Time: {sw.Elapsed}");
        Console.ReadKey();
    }

    public int ClimbStairs(int n)
    {
        if (n <= 3)
        {
            return n;
        }
        else
        {
            int prev1 = 2;
            int prev2 = 3;
            int i = 4;
            while (i <= n)
            {
                int current = prev1 + prev2;
                prev1 = prev2;
                prev2 = current;
                i++;
            }
            return prev2;
        }
    }
}