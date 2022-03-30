using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева
            //От общата сума, Мария трябва да плати 5 % данъци.
            const double magnoliaPrice = 3.25;
            const int zumbulPrice = 4;
            const double rosePrice = 3.50;
            const int cactus = 8;

            int numOfMagnolia = int.Parse(Console.ReadLine());
            int numOfZumbul = int.Parse(Console.ReadLine());
            int numOfRose = int.Parse(Console.ReadLine());
            int numOfCactus = int.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double sumPrice = magnoliaPrice * numOfMagnolia + zumbulPrice * numOfZumbul + rosePrice * numOfRose + cactus * numOfCactus;
            double profit = sumPrice-(0.05 * sumPrice);
            double difference = Math.Abs(profit - priceOfGift);

            if (sumPrice>=priceOfGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }



        }
    }
}
