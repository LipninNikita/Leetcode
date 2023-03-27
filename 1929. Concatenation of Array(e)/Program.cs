using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(GetConcatenation(new int[5]));
    }
    public static int[] GetConcatenation(int[] nums)
    {
        //Создает массив длинной в два массива nums, а затем  просто дважды копирует массив nums в arr со сдвигом

        var arr = new int[nums.Length * 2];

        Array.Copy(nums, arr, nums.Length);
        Array.Copy(nums, 0, arr, nums.Length, nums.Length);
        return arr;
    }
}