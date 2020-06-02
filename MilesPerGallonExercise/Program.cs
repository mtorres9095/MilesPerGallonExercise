using System;

namespace MilesPerGallonExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate Miles per Gallon given miles driven and gas consumed
            double milesDriven;
            double gasConsumed;
            string input1;
            string input2;
            double milesPerGallon;

            Console.WriteLine("Enter Miles Driven:");
            input1 = Console.ReadLine();
            Console.WriteLine("Enter Gas Consumed:");
            input2 = Console.ReadLine();
            milesDriven = double.Parse(input1);
            gasConsumed = double.Parse(input2);
            milesPerGallon = milesDriven / gasConsumed;

            Console.WriteLine("Miles per Gallon = "+milesPerGallon);
        }
    }
}
