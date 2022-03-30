using System;

namespace CarToGo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classCar = "";
            string car = "";
            double price = 0;

            switch (season)
            {
                case "Summer":
                    if (budget<=100)
                    {
                        classCar = "Economy class";
                        car = "Cabrio";
                        price = budget * 0.35;
                    }
                    else if (budget>100&&budget<=500)
                    {
                        classCar = "Compact class";
                        car = "Cabrio";
                        price = budget * 0.45;
                    }
                    else if (budget>500)
                    {
                        classCar = "Luxury class";
                        car = "Jeep";
                        price = 0.90 * budget;
                    }
                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        classCar = "Economy class";
                        car = "Jeep";
                        price = budget * 0.65;
                    }
                    else if (budget > 100 && budget <= 500)
                    {
                        classCar = "Compact class";
                        car = "Jeep";
                        price = budget * 0.80;
                    }
                    else if (budget > 500)
                    {
                        classCar = "Luxury class";
                        car = "Jeep";
                        price = 0.90 * budget;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{classCar}");
            Console.WriteLine($"{car} - {price:f2}");
        }
    }
}
