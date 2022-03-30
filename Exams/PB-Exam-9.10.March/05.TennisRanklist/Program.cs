using System;

namespace _05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            double currPoints = 0;
            double averagePoints = 0;
            double percentPoints = 0;
            double countWin = 0;
            for (int i =1; i <= tournaments; i++)
            {
                string results = Console.ReadLine();
                if (results=="W")
                {
                    countWin++;
                    currPoints += 2000;
                }
                if (results=="F")
                {
                    currPoints += 1200;
                }
                if (results=="SF")
                {
                    currPoints += 720;
                }
            }
            averagePoints = currPoints / tournaments;
            points += currPoints; 
            percentPoints = countWin / tournaments * 100;
            Console.WriteLine($"Final points: {Math.Floor(points)}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentPoints:F2}%");
        }
    }
}
