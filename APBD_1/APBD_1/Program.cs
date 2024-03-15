public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int g = 19;
        float a = 32154;
        int[] arr = {1,2,3,412,23};
        Console.WriteLine(FindMax(arr));
    }
    public static int FindMax(int[] ints){
        int temp_max = 0;
        for(int i = 0;i<ints.Length;i++){
            if (ints[i]>temp_max){
                temp_max = ints[i];
            }
        }
        return temp_max;
    }
}
