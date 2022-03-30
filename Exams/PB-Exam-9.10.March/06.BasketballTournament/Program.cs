using System;

namespace _06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            double wins = 0;
            double losts = 0;
            double games = 0;
            int difference = 0;
            while (input!="End of tournaments")
            {
                int numberOfGames = int.Parse(Console.ReadLine());
                games += numberOfGames;
                for (int i = 1; i <= numberOfGames; i++)
                {
                    int teamDesi = int.Parse(Console.ReadLine());
                    int teamOther = int.Parse(Console.ReadLine());

                    if (teamDesi>teamOther)
                    {
                        wins++;
                        difference = teamDesi - teamOther;
                        Console.WriteLine($"Game {i} of tournament {input}: win with {difference} points.");
                    }
                    else
                    {
                        losts++;
                        difference = teamOther - teamDesi;
                        Console.WriteLine($"Game {i} of tournament {input}: lost with {difference} points.");
                    }
                }
                input =Console.ReadLine();
            }
            double percentWins = wins / games * 100;
            double percentLosts = losts / games * 100;
            Console.WriteLine($"{percentWins:f2}% matches win");
            Console.WriteLine($"{percentLosts:f2}% matches lost");
        }
    }
}
