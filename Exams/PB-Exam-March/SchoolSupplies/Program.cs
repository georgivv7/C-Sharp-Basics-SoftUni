using System;

namespace SchoolSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPens = int.Parse(Console.ReadLine());
            int numOfMarkers = int.Parse(Console.ReadLine());
            double litresOfWasher = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePens = numOfPens * 5.80;
            double priceMarkers = numOfMarkers * 7.2;
            double priceWasher = litresOfWasher * 1.20;
            double sumAll = pricePens + priceMarkers + priceWasher;
            sumAll -= ((sumAll * discount) / 100);
            Console.WriteLine($"{sumAll:f3}");
        }
    }
}
