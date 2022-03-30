using System;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double priceStatuets = rent - (rent * 0.30);
            double priceCatering = priceStatuets - (priceStatuets * 0.15);
            double sounding = priceCatering / 2;
            double sum = rent+priceStatuets + priceCatering + sounding;

            Console.WriteLine($"{sum:F2}");

        }
    }
}
