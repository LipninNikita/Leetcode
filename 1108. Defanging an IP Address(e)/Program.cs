internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public string DefangIPaddr(string address) 
    {
        return address.Replace(".", "[.]");
    }
}