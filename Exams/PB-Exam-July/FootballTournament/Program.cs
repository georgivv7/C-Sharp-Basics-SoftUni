using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            double countWins = 0;
            double countDraws = 0;
            double countLosts = 0;
            double points = 0;
            double winRate = 0;
            for (int i = 1; i <= games; i++)
            {
                char exit = char.Parse(Console.ReadLine());
                switch (exit)
                {
                    case'W':
                        countWins++;
                        points += 3;
                        break;
                    case 'D':
                        countDraws++;
                        points += 1;
                        break;
                    case 'L':
                        countLosts++;
                        points += 0;
                        break;
                }
            }
            winRate = (countWins / games)*100;
            if (games<=0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{team} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countWins}");
                Console.WriteLine($"## D: {countDraws}");
                Console.WriteLine($"## L: {countLosts}");
                Console.WriteLine($"Win rate: {winRate:f2}%");
            }

        }
    }
}
