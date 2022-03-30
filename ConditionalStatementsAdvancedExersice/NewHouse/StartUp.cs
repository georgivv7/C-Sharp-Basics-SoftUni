using System;

namespace NewHouse
{
    class StartUp
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

            double price = 0;
            double totalPrice = 0;
           

            if (typeOfFlower=="Roses")
            {
                if (quantity>80)
                {
                    price = quantity * priceRose;
                    totalPrice =price - price * 0.10;
                }
                else
                {
                    totalPrice = quantity * priceRose;
                }
                
            }
            else if (typeOfFlower=="Dahlias")
            {
                if (quantity > 90)
                {
                    price = quantity * priceDahlia;
                    totalPrice = price - price * 0.15;
                }
                else
                {
                    totalPrice = quantity * priceDahlia;
                }
                
            }
            else if (typeOfFlower=="Tulips")
            {
                if (quantity>80)
                {
                    price = quantity * priceTulip;
                    totalPrice = price - price * 0.15;
                }
                else
                {
                    totalPrice = quantity * priceTulip;
                }
                
            }
            else if (typeOfFlower=="Narcissus")
            {
                if (quantity<120)
                {
                    price = quantity * priceNarcissus;
                    totalPrice = price + price * 0.15;
                }
                else
                {
                    totalPrice = quantity * priceNarcissus;
                }
                
            }
            else if (typeOfFlower=="Gladiolus")
            {
                if (quantity<80)
                {
                    price = quantity * priceGladiolus;
                    totalPrice = price + price * 0.20;
                }
                else
                {
                    totalPrice = quantity * priceGladiolus;
                }
                
            }
            if (budget>=totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeOfFlower} and {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice-budget:f2} leva more.");
            }


        }
    }
}
