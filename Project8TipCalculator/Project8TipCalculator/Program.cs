using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8TipCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project 8: Tip Calculator by Brandon Phillips\n");

            double mealCost, tip15Value, tip18Value, tip20Value, tip22Value, tip25Value, total;

            Console.Write("What is the cost of the meal?: ");
            mealCost = double.Parse(Console.ReadLine());

            // 15%
            tip15Value = calcTip(mealCost, 15);
            total = calcTotal(mealCost, tip15Value);
            display(total, tip15Value, "15");
            // 18%
            tip18Value = calcTip(mealCost, 18);
            total = calcTotal(mealCost, tip18Value);
            display(total, tip18Value, "18");
            // 20%
            tip20Value = calcTip(mealCost, 20);
            total = calcTotal(mealCost, tip20Value);
            display(total, tip18Value, "20");
            // 22%
            tip22Value = calcTip(mealCost, 22);
            total = calcTotal(mealCost, tip22Value);
            display(total, tip22Value, "22");
            // 25%
            tip25Value = calcTip(mealCost, 25);
            total = calcTotal(mealCost, tip25Value);
            display(total, tip25Value, "25");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static double calcTip(double cost, double tipPct)
        {
            return cost * (tipPct / 100);
        }
        public static double calcTotal(double cost, double tipAmt)
        {
            return cost + tipAmt;
        }
        public static void display(double total, double tip, string tipP)
        {
            Console.WriteLine($"\n{tipP} percent tip = {tip:C}, total cost = {total:C}");
        }
    }
}
