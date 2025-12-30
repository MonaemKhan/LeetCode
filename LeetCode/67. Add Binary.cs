using System.Diagnostics;
using System.Numerics;
using System.Text;

class TestClass
{

    static async Task Main(string[] args)
    {
        TestClass testClass = new TestClass();
        Stopwatch sw = Stopwatch.StartNew();
        var testCases = new List<(string[] inputs, string expected)>
        {
            //(new string[] { "11", "1" }, "100"),
            //(new string[] { "1010", "1011" }, "10101"),
            //(new string[] { "0", "0" }, "0"),
            //(new string[] { "1", "0" }, "1"),
            //(new string[] { "1111", "1111" }, "11110"),
            //(new string[] { "101", "10" }, "111"),
            (new string[] { "1001", "111" }, "11000")
        };

        // Example of using the test cases
        foreach (var testCase in testCases)
        {
            string result = testClass.AddBinary(testCase.inputs[0], testCase.inputs[1]);
            Console.WriteLine($"Input: {testCase.inputs[0]}, {testCase.inputs[1]} | Expected: {testCase.expected} | Got: {result} | {testCase.expected==result}");
        }
        sw.Stop();

        // 4. Output results
        Console.WriteLine($"Elapsed Milliseconds: {sw.ElapsedMilliseconds}ms");
        Console.WriteLine($"Total Elapsed Time: {sw.Elapsed}");
        Console.ReadKey();
    }

    public string AddBinary(string a, string b)
    {
        int maxLength = Math.Max(a.Length, b.Length);
        var aArr = a.PadLeft(maxLength,'0').ToCharArray();
        var bArr = b.PadLeft(maxLength, '0').ToCharArray();
        string reminder = "0";
        string result = "";
        for (int i = maxLength - 1; i >= 0; i--)
        {
            string aChar = aArr[i].ToString();
            string bChar = bArr[i].ToString();

            if (aChar == "1" && bChar == "1")
            {
                if (reminder == "1")
                {
                    result = "1" + result;
                    reminder = "1";
                }
                else
                {
                    result = "0" + result;
                    reminder = "1";
                }
            }
            else if (aChar == "0" && bChar == "0")
            {
                if (reminder == "1")
                {
                    result = "1" + result;
                    reminder = "0";
                }
                else
                {
                    result = "0" + result;
                    reminder = "0";
                }
            }
            else
            {
                if (reminder == "1")
                {
                    result = "0" + result;
                    reminder = "1";
                }
                else
                {
                    result = "1" + result;
                    reminder = "0";
                }
            }
        }

        if(reminder == "1")
        {
            result = "1" + result;
        }

        return result;
    }
}