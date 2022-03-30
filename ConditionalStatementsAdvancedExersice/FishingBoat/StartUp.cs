using System;

namespace FishingBoat
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const int rentSpring = 3000;
            const int rentSummer = 4200;
            const int rentWinter = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishermans = int.Parse(Console.ReadLine());

            double discount = 0;
            double price = 0;

            switch (season)
            {
                case "Spring":
                    if (numOfFishermans <= 6)
                    {
                        discount = rentSpring * 0.10;
                        price = rentSpring - discount;
                    }
                    else if (numOfFishermans>=7&&numOfFishermans<=11)
                    {
                        discount = rentSpring * 0.15;
                        price = rentSpring - discount;
                    }
                    else if (numOfFishermans>=12)
                    {
                        discount = rentSpring * 0.25;
                        price = rentSpring - discount;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    if (numOfFishermans <= 6)
                    {
                        discount = rentSummer * 0.10;
                        price = rentSummer - discount;
                    }
                    else if (numOfFishermans >= 7 && numOfFishermans <= 11)
                    {
                        discount = rentSummer * 0.15;
                        price = rentSummer - discount;
                    }
                    else if (numOfFishermans >= 12)
                    {
                        discount = rentSummer * 0.25;
                        price = rentSummer - discount;
                    }
                    break;
                case "Winter":
                    if (numOfFishermans <= 6)
                    {
                        discount = rentWinter * 0.10;
                        price = rentWinter - discount;
                    }
                    else if (numOfFishermans >= 7 && numOfFishermans <= 11)
                    {
                        discount = rentWinter * 0.15;
                        price = rentWinter - discount;
                    }
                    else if (numOfFishermans >= 12)
                    {
                        discount = rentWinter * 0.25;
                        price = rentWinter - discount;
                    }
                    break;
                    
                
            }
            if (season=="Autumn")
            {
                price = price;
            }
            else if (numOfFishermans % 2 == 0)
            {
                price = price - price * 0.05;
            }
           
            double difference = budget - price;
            if (difference>=0)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva.");
            }

        }
    }
}
