using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string packet = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;

            switch (movie)
            {
                case "John Wick":
                    if (packet == "Drink")
                    {
                        price += 12 * tickets;
                    }
                    else if (packet == "Popcorn")
                    {
                        price += 15 * tickets;
                    }
                    else if (packet == "Menu")
                    {
                        price += 19 * tickets;
                    }
                    break;
                case "Jumanji":
                    if (packet == "Drink")
                    {
                        price += 9 * tickets;
                    }
                    else if (packet == "Popcorn")
                    {
                        price += 11 * tickets;
                    }
                    else if (packet == "Menu")
                    {
                        price += 14 * tickets;
                    }
                    if (tickets == 2)
                    {
                        discount = price * 0.15;
                        price -= discount;
                    }
                    break;
                case "Star Wars":
                    if (packet == "Drink")
                    {
                        price += 18 * tickets;
                    }
                    else if (packet == "Popcorn")
                    {
                        price += 25 * tickets;
                    }
                    else if (packet == "Menu")
                    {
                        price += 30 * tickets;
                    }
                    if (tickets >= 4)
                    {
                        discount = price * 0.30;
                        price -= discount;
                    }
                    break;
            }
            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}
