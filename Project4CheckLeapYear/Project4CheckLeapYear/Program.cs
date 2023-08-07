namespace Project4CheckLeapYear
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Project 4: Leap Year Check by Brandon Phillips\n");

            Console.Write("Enter a year: ");
            int inputYear = int.Parse(Console.ReadLine());

            int resultDays = DaysInFeb(inputYear);
            Console.WriteLine($"Number of days in Feb is: {resultDays}");

            bool isLeapYear = CheckLeapYear(inputYear);
            if (isLeapYear) { Console.WriteLine("This year IS a leap year."); }
            else { Console.WriteLine("This year is NOT a leap year."); }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        public static int DaysInFeb(int yr)
        {
            int result;
            if (yr % 100 == 0)
            {
                if (yr % 400 == 0)
                    result = 29;
                else
                    result = 28;
            }
            else if (yr % 4 == 0)
                result = 29;
            else
                result = 28;
            return result;
        }

        public static bool CheckLeapYear(int yr)
        {
            bool isLeapYear = false;
            if (yr % 100 == 0)
            {
                if (yr % 400 == 0)
                    isLeapYear = true;
                else
                    isLeapYear = false;
            }
            else if (yr % 4 == 0)
                isLeapYear = true;
            else
                isLeapYear = false;
            return isLeapYear;
        }
    }
}