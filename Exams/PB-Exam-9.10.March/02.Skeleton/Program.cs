using System;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int secondsTo100 = int.Parse(Console.ReadLine());

            int controlSeconds = minutes * 60 + seconds;
            double timesReduced = distance / 120;
            double secondsReduced = timesReduced * 2.5;
            double marinTime = (distance / 100) * secondsTo100 - secondsReduced;

            if (marinTime<=controlSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            else
            {
                marinTime -= controlSeconds;
                Console.WriteLine($"No, Marin failed! He was {marinTime:f3} second slower.");
            }

        }
    }
}
