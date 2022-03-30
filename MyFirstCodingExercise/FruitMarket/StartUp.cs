using System;

namespace FruitMarket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRaspberry = double.Parse(Console.ReadLine());
            double quantityStrawberry = double.Parse(Console.ReadLine());

            double priceOfRaspberry = priceStrawberry / 2;
            double priceOfOranges = priceOfRaspberry - (priceOfRaspberry * 0.40);
            double priceOfBananas = priceOfRaspberry - (priceOfRaspberry * 0.8);

            double sumOfRaspberry = priceOfRaspberry * quantityRaspberry;
            double sumOfOranges = priceOfOranges * quantityOranges;
            double sumOfOBananas = priceOfBananas * quantityBananas;
            double sumOfStrawberry = priceStrawberry * quantityStrawberry;
            double totalSum = sumOfRaspberry + sumOfOranges + sumOfOBananas + sumOfStrawberry;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
