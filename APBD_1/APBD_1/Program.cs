public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int g = 19;
        int a = 123;
        string a3 = "dsag";
    }

    public static void CalculateAvg(int[] arr)
    {
        double summ = 0;
        double avg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            summ += arr[i];
        }

        avg = summ / arr.Length;
    }
}
