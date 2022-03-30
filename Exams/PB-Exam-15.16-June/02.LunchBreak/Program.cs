using System;

namespace _02.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = Console.ReadLine();
            double durationEpisode = double.Parse(Console.ReadLine());
            double durationPause = double.Parse(Console.ReadLine());

            double timeLunch = durationPause / 8;
            double timeRelax = durationPause / 4;
            double totalTime = durationPause-(timeLunch + timeRelax);

            if (totalTime>=durationEpisode)
            {
                totalTime -= durationEpisode;
                Console.WriteLine($"You have enough time to watch {tvShow}" +
                    $" and left with {Math.Ceiling(totalTime)} minutes free time.");
            }
            else
            {
                durationEpisode -= totalTime;
                Console.WriteLine($"You don't have enough time to watch {tvShow}," +
                    $" you need {Math.Ceiling(durationEpisode)} more minutes.");
            }
        }
    }
}
