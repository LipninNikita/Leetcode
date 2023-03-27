internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(313).ToString());
    }
    public static bool IsPalindrome(int x)
    {
        var str = x.ToString().Reverse();
        var newStr = new String(str.ToArray());

        if (x.ToString() == newStr)
            return true;
        else
            return false;
    }
}