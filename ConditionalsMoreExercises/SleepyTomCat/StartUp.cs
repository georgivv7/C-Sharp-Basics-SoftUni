using System;

namespace SleepyTomCat
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int daysWithoutJob = int.Parse(Console.ReadLine());
            const int norm = 30000;
            int playingTimeWithJob = 63;
            int playingTimeWithoutJob = 127;

            int workingDays = 365 - daysWithoutJob;
            int totalPlayingTime = workingDays * playingTimeWithJob + daysWithoutJob * playingTimeWithoutJob;
            int morePlayingTime = Math.Abs(totalPlayingTime - norm);
            int hours = morePlayingTime / 60;
            int minutes = morePlayingTime % 60;

            if (totalPlayingTime>norm)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");

            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
