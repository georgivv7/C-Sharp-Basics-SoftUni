using System;

namespace MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double SecondsFor1meter = double.Parse(Console.ReadLine());

            double time = distanceInMeters * SecondsFor1meter;
            double resistance = Math.Floor(distanceInMeters / 50) * 30;
            double totalTime = time + resistance;

            if (totalTime<recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-recordInSeconds:f2} seconds slower.");
            }



        }
    }
}
