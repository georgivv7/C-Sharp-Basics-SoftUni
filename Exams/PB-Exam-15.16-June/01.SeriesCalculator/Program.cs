using System;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double durationEpisode = double.Parse(Console.ReadLine());

            double ads = durationEpisode * 0.20;
            double special = seasons * 10;
            double episodeTime = ads + durationEpisode;
            double total = seasons * episodes * episodeTime + special;

            Console.WriteLine($"Total time needed to watch the {tvShow} series is {Math.Floor(total)} minutes.");
        }
    }
}
