internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ToLowerCase("Hello, World!"));
    }
    public static string ToLowerCase(string s) 
    {
        return s.ToLower();
    }
}