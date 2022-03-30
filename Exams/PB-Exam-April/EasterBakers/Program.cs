using System;

namespace EasterBakers
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            double numOfSetsEggs = double.Parse(Console.ReadLine());
            double packetMaya = double.Parse(Console.ReadLine());

            double priceSugar = priceFlour * 0.75;
            double priceEggs = priceFlour * 1.1;
            double priceMaya = priceSugar * 0.20;

            double sumEggs = priceEggs * numOfSetsEggs;
            double sumFlour = priceFlour * kgFlour;
            double sumSugar = priceSugar * kgSugar;
            double sumMaya = priceMaya * packetMaya;

            double sum = sumEggs+sumFlour+sumSugar+sumMaya;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
