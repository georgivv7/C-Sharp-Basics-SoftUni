using System;

namespace TournamentOfChristmas
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string command = string.Empty;
            double moneyEarned = 0;
            int countWins = 0;
            int countLoses = 0;
            for (int i = 1; i <= days; i++)
            {
                string sport = Console.ReadLine();
                string result = Console.ReadLine();
                if (result == "win")
                {
                    countWins++;
                    moneyEarned += 20;
                }
                if (result == "lose")
                {
                    countLoses++;
                }
                if (countWins > countLoses)
                {
                    moneyEarned += moneyEarned * 0.10;
                }
            }
            
        }
    }
}
