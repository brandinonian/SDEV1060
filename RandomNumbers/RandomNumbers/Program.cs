namespace RandomNumbers;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing Random Numbers by Brandon Phillips\n");
    }

    public static int getRN(int min, int max)
    {
        Random rng = new Random();
        int answer = rng.Next(min, max + 1);
        return answer;
    }
}