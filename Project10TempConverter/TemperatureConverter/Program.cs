namespace TemperatureConverter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter by Brandon Phillips\n");

            // Declare variables:
            string answer = "y";
            string tempType = "f";
            double userTemp = 0.0;
            double result = 0.0;

            while (answer == "y")
            {
                Console.Write("\nWhat is the temperature to convert? ");
                userTemp = double.Parse(Console.ReadLine());
                Console.Write("Is this Celsius (C) or Fahrenheit (F): ");
                tempType = Console.ReadLine().ToLower();
                if (tempType == "c")
                {
                    result = CtoF(userTemp);
                    Console.WriteLine("Fahrhenheit temp is " + result);
                }
                else if (tempType == "f")
                {
                    result = FtoC(userTemp);
                    Console.WriteLine("Celsius temp is " + result);
                }
                else
                    Console.WriteLine("Error, use C or F for temperature type");

                Console.Write("Do you have another temperature to convert? ");
                answer = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static double CtoF(double Ctemp)
        {
            double Ftemp = 0.0;

            Ftemp = (Ctemp * 9.0 / 5.0) + 32;

            return Ftemp;
        }

        public static double FtoC(double Ftemp)
        {
            double Ctemp = 0.0;

            Ctemp = (Ftemp - 32) * 5.0 / 9.0;

            return Ctemp;
        }
    }
}