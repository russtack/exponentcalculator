internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(GetPow(5, 4));
       
    }
     static int GetPow(int baseNum, int powNum)
    {
        int result = 1;
        for (int i = 0; i < powNum; i++)
        {
            result *= baseNum;

        }
        return result;
    }
}