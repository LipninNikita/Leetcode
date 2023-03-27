internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Reverse(101));      
    }

    public static int Reverse(int x)
    {
        try
        {
            var str = x.ToString();
            var charArr = str.Reverse();
            var strNew = "";
            foreach (var charik in charArr)
            {
                if (charik == '-')
                    strNew = strNew.Insert(0, "-");
                else
                    strNew += charik;
            }
            return Int32.Parse(strNew);
        }
        catch
        {
            return 0;
        }
    }
}