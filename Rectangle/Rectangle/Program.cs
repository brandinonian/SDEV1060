using Rectangle;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Box Unit Tests by Brandon Phillips\n");

        int length, width, height, area, perimeter, volume;

        Console.Write("Enter the length: ");
        length = int.Parse(Console.ReadLine());
        Console.Write("Enter the width: ");
        width = int.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        height = int.Parse(Console.ReadLine());

        Box myPaper = new Box(length, width, height);
        area = myPaper.calcArea();
        perimeter = myPaper.calcPerimeter();
        volume = myPaper.calcVolume();

        Console.WriteLine($"\nArea = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
        Console.WriteLine($"Volume = {volume}");

        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}