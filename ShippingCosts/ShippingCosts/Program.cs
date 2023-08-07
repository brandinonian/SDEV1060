using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCosts
{
    public class Program
    {
        // UI for the project
        static void Main(string[] args)
        {
            Console.WriteLine("Shipping Costs by Brandon Phillips\n");

            string reply = "";
            do
            {
                bool repeat = false;
                double weight = 0;
                double distance = 0;

                do
                {
                    try
                    {
                        Console.Write("\nEnter the weight: ");
                        weight = double.Parse(Console.ReadLine());
                        repeat = false;
                    }
                    catch (Exception e)
                    {
                        repeat = true;
                        Console.WriteLine(e.Message);
                    }
                } while (repeat);


                do
                {
                    try
                    {
                        Console.Write("\nEnter the distance: ");
                        distance = double.Parse(Console.ReadLine());
                        repeat = false;
                    }
                    catch (Exception e)
                    {
                        repeat = true;
                        Console.WriteLine(e.Message);
                    }
                } while (repeat);

                double cost = CalculateShippingCost(weight, distance);
                Console.WriteLine($"\nCost to ship this package: {cost:C}");

                while (reply != "y" && reply != "n")
                {
                    Console.Write("\nCalculate another? (Y/n)");
                    reply = Console.ReadLine().ToLower();
                }
            } while (reply == "y");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        // helper methods to calculate shipping costs
        public static double CalculateShippingCost(double weight, double distance)
        {
            double weightFactor = CalculateWeightFactor(weight);
            double distanceFactor = CalculateDistanceFactor(distance);
            return weightFactor * distanceFactor;
        }
        public static double CalculateWeightFactor(double weight)
        {
            if (weight < 10)
                return 2.5;
            else if (weight < 25)
                return 10;
            else
                return 25;
        }
        public static double CalculateDistanceFactor(double distance)
        {
            if (distance < 100)
                return 2;
            else if (distance < 500)
                return 5;
            else
                return 10;
        }
    }
}
