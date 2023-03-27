internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
    }
    public static int NumJewelsInStones(string jewels, string stones) 
    {
        int counter = 0;
        foreach(var stone in stones)
        {
            foreach (var jewel in jewels)
            {
                if (jewel.ToString().Contains(stone))
                counter++;
            }
        }
        return counter;
    }
}