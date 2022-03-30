using System;

namespace Harvest
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int XsquareMeters = int.Parse(Console.ReadLine());
            double grapeFromSquareMeter = double.Parse(Console.ReadLine());
            int wineLeters = int.Parse(Console.ReadLine());
            int numOfWorkers = int.Parse(Console.ReadLine());

            double grape = XsquareMeters * grapeFromSquareMeter;
            double wine = (grape * 0.4)/2.5;
            double totalWine = Math.Abs(wine - wineLeters);

            if (wine>wineLeters)
            {
                
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(totalWine)} liters left -> {Math.Ceiling(totalWine/2)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {totalWine} liters wine needed.");
            }


        }
    }
}
