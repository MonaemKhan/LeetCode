class TestClass
{
    
    static void Main(string[] args)
    {
        var re = Divide(-2147483648, -1);
        Console.WriteLine("Length: " + re);
        Console.ReadKey();
    }
    public static int Divide(int dividend, int divisor)
    {
        long dived = Convert.ToInt64(dividend);
        long divsor = Convert.ToInt64(divisor);
        long result = (dived / (divsor * 1));

        if(result > int.MaxValue)
        {
            return int.MaxValue;
        }
        else if(result < int.MinValue)
        {
            return int.MinValue;
        }
        else
        {
            return Convert.ToInt32(result);
        }
    }

}