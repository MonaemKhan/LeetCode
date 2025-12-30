using System.Diagnostics;
using System.Text;

class TestClass
{
    
    static async Task Main(string[] args)
    {
        TestClass testClass = new TestClass();
        
        Console.ReadKey();
    }

    public int MinDeletionSize(string[] strs) {
        int delete = 0;
int rows = strs.Length;
int cols = strs[0].Length;
bool[] sorted = new bool[rows - 1];

for (int c = 0; c < cols; c++)
{
    bool isDelete = false;
    for (int r = 0; r < rows - 1; r++)
    {
        if (!sorted[r] && strs[r][c] > strs[r + 1][c])
        {
            isDelete = true;
        }
    }

    if(isDelete)
    {
        delete++;
        continue;
    }

    for (int r = 0; r < rows - 1; r++)
    {
        if (!sorted[r] && strs[r][c] < strs[r + 1][c])
        {
            sorted[r] = true;
        }
    }
}
return delete;
    }

}