﻿using MPGCalculator;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MPG Calculator by Brandon Phillips\n");

        // hardcoded data
        MPG trip1 = new MPG(320, 29);
        MPG trip2 = new MPG(325.8, 32.1);
        MPG trip3 = new MPG(412.5, 35);
        MPG trip4 = new MPG(345, 32.6);

        trip1.displayCurrentMPG();
        trip2.displayCurrentMPG();
        trip3.displayCurrentMPG();
        trip4.displayCurrentMPG();

        MPG.displayTotalMPG();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}