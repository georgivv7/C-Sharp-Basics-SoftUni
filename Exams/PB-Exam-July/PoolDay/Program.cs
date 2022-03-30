using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entryTax = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double priceEntry = entryTax * people;
            double priceSunbed = Math.Ceiling(0.75 * people) * sunbedPrice;
            double priceUmbrella = Math.Ceiling(0.50 * people) * umbrellaPrice;
            double sum = priceEntry + priceSunbed + priceUmbrella;
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
