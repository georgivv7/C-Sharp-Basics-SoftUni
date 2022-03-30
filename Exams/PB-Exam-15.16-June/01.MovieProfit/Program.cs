using System;

namespace _01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double tickets = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double income = days * tickets * price;
            double percentCinema = income * (percent / 100);
            double profit = income - percentCinema;

            Console.WriteLine($"The profit from the movie {movie} is {profit:F2} lv.");
        }
    }
}
