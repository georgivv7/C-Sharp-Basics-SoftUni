using System;

namespace _02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeShooting = double.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int timeScene = int.Parse(Console.ReadLine());

            double terrainWork = timeShooting * 0.15;
            double timeScenes = timeScene * scenes;
            double totalTime = terrainWork + timeScenes;

            if (timeShooting>=totalTime)
            {
                timeShooting -= totalTime;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeShooting)} minutes left!");
            }
            else
            {
                totalTime -= timeShooting;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(totalTime)} minutes.");
            }

        }
    }
}
