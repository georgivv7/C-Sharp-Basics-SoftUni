using System;

namespace NewHome1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceRose = 5;
            double priceDahlia = 3.80;
            double priceTulip = 2.80;
            double priceNarcissus = 3;
            double priceGladiolus = 2.50;

            string typeOfFlower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (typeOfFlower)
            {
                case "Roses":
                    totalPrice = quantity * priceRose;
                    if (quantity>80)
                    {
                        totalPrice *= 0.9;
                    }
                    break;
                case "Dahlias":totalPrice = quantity * priceDahlia;
                    if (quantity>90)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Tulips":totalPrice = quantity * priceTulip;
                    if (quantity>80)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Narcissus":totalPrice = quantity * priceNarcissus;
                    if (quantity<120)
                    {
                        totalPrice *= 1.15;
                    }
                    break;
                case "Gladiolus":totalPrice = quantity * priceGladiolus;
                    if (quantity<80)
                    {
                        totalPrice *= 1.20;
                    }
                    break;
                default:
                    break;

            }
            double difference = Math.Abs(budget - totalPrice);
            if (budget>totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeOfFlower} and {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
