using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMovies = int.Parse(Console.ReadLine());
            double bestRating = double.MinValue;
            double lowestRating = double.MaxValue;
            double averageRating = 0;
            string best = "";
            string lowest = "";
            double sum = 0;
            for (int i = 1; i <= numMovies; i++)
            {
                string movie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                sum += rating;
                if (rating > bestRating)
                {
                    bestRating = rating;
                    best = movie;
                }
                else if (rating < lowestRating)
                {
                    lowestRating = rating;
                    lowest = movie;
                }
            }
            averageRating = sum / numMovies;
            Console.WriteLine($"{best} is with highest rating: {bestRating:f1}");
            Console.WriteLine($"{lowest} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
