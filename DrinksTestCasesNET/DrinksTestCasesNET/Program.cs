using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksTestCasesNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Purchase Drinks");

            Boolean more = true;
            String answer;
            int lgQty, smQty;
            double lgPrice = 3.00;
            double smPrice = 1.50;
            double lgCost = 0.0;
            double smCost = 0.0;
            double totalCost = 0.0;

            while (more)
            {
                Console.WriteLine("\nLarge drinks = $2.50, Small drinks = $1.50");
                Console.Write("How many large drinks? ");
                lgQty = int.Parse(Console.ReadLine());
                Console.Write("How many small drinks? ");
                smQty = int.Parse(Console.ReadLine());

                lgCost = lgQty * lgPrice;
                smCost = smQty * smPrice;
                totalCost = lgCost + smCost;

                Console.WriteLine($"  Large Drinks = {lgCost}");
                Console.WriteLine($"  Small Drinks = {smCost}");
                Console.WriteLine($"Total cost = {totalCost}");

                Console.Write("Another order? ");
                answer = Console.ReadLine();
                if (answer.Equals("n") || answer.Equals("N"))
                    more = false;
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
