namespace CheckDigits
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Project 9: Check Digits by Brandon Phillips\n");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        public static double CalcTotal(double num1, double num2, double num3, double num4)
        {
            return num1 + num2 + num3 + num4;
        }
        public static double CalcAvg(double num1, double num2, double num3, double num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }

        public static double FindLargest(double num1, double num2, double num3, double num4, double largest)
        {
            return largest;
        }
        public static double FindSmallest(double num1, double num2, double num3, double num4, double smallest)
        {
            return smallest;
        }
    }
}