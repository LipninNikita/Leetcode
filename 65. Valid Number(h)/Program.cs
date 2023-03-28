internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsNumber("Infinity"));
    }
    public static bool IsNumber(string s)
    {
        bool status = true;

        if (s.Contains("Infinity"))
            return false;

        try
        {
            var i = Convert.ToDouble(s);
        }
        catch (System.FormatException)
        {
            status = false;
        }
        catch (System.OverflowException)
        {
            status = true;
        }
        return status;
    }
}