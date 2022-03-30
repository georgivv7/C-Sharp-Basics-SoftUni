using System;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            switch (destination)
            {
                case "Dubai":
                    if (season == "Winter")
                    {
                        price = 45000 * days;
                        discount = price * 0.30;
                        price -= discount;
                    }
                    else if (season == "Summer")
                    {
                        price = 40000 * days;
                        discount = price * 0.30;
                        price -= discount;
                    }
                    break;
                case "Sofia":
                    if (season == "Winter")
                    {
                        price = 17000 * days;
                        discount = price * 0.25;
                        price += discount;
                    }
                    else if (season == "Summer")
                    {
                        price = 12500 * days;
                        discount = price * 0.25;
                        price += discount;
                    }
                    break;
                case "London":
                    if (season == "Winter")
                    {
                        price = 24000 * days;
                    }
                    else if (season == "Summer")
                    {
                        price = 20250 * days;
                    }
                    break;
            }
            if (budget >= price)
            {
                budget -= price;
                Console.WriteLine($"The budget for the movie is enough! We have {budget:F2} leva left!");
            }
            else
            {
                price -= budget;
                Console.WriteLine($"The director needs {price:F2} leva more!");
            }
        }
    }
}
