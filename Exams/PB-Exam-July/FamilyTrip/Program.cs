using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            double percentExtraCost = double.Parse(Console.ReadLine());
            percentExtraCost /= 100;

            if (nights > 7)
            {
                priceNight -= priceNight * 0.05;
            }
            double nightsCost = nights * priceNight;
            double extraCost = percentExtraCost * budget;
            double sumCost = nightsCost + extraCost;

            if (budget>=sumCost)
            {
                budget -= sumCost;
                Console.WriteLine($"Ivanovi will be left with {budget:f2} leva after vacation.");
            }
            else
            {
                sumCost -= budget;
                Console.WriteLine($"{sumCost:f2} leva needed.");
            }
            

        }
    }
}
