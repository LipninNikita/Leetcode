internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsStrictlyPalindromic(9));
    }
    public static bool IsStrictlyPalindromic(int n) 
    {
        string binary = Convert.ToString(n, 2);

        var str = binary.Reverse().ToArray().ToString();

        if (binary == str)
            return true;
        else
            return false;
    }
}