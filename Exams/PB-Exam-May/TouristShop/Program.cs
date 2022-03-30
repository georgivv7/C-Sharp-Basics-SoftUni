using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input =Console.ReadLine();
            int counter = 0;
            double bill = 0;
            while (input!="Stop")
            {
                double price = double.Parse(Console.ReadLine());
                counter++;
                if (counter % 3 == 0)
                {
                    price = price / 2;
                }
                bill += price;
                if (budget < price)
                {
                    price -= budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {price:f2} leva!");
                    break;
                }             
                budget -= price;                             
                input =Console.ReadLine();
            }
            if (input=="Stop")
            {
                Console.WriteLine($"You bought {counter} products for {bill:f2} leva.");
            }
            
        }
    }
}
