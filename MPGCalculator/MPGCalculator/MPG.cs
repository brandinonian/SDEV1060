using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPGCalculator
{
    public class MPG
    {
        private static double totalMiles, totalGallons, totalMPG;
        private static int numTrips = 0;
        private double miles, gallons, mpg;

        public MPG(double miles, double gallons)
        {
            this.miles = miles;
            this.gallons = gallons;
            this.mpg = this.miles / this.gallons;
            totalMiles += miles;
            totalGallons += gallons;
            numTrips++;
            totalMPG = totalMiles / totalGallons;
        }

        public void displayCurrentMPG()
        {
            Console.WriteLine($"This trip = {mpg:n2}");
        }

        public static void displayTotalMPG()
        {
            Console.WriteLine($"\nFor {numTrips} tips, total MPG = {totalMPG:n2}");
        }

        public double getMiles() { return miles; }
        public double getGallons() { return gallons; }
        public double getMPG() { return mpg; }
        public double getTotalMiles() {  return totalMiles; }
        public double getTotalGallons() {  return totalGallons; }
        public double getTotalMPG() {  return totalMPG; }
        public int getNumTrips() { return numTrips;}
    }
}
