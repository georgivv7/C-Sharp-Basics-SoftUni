using System;

namespace ChristmasTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double moneyEarned = 0;
            int daysWon = 0;
            int daysLost = 0;

            for (int i = 1; i <= days; i++)
            {
                double dailyMoney = 0;
                int win = 0;
                int lose = 0;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Finish")
                    {
                        break;
                    }
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        win++;
                        dailyMoney += 20;
                    }
                    if (result == "lose")
                    {
                        lose++;
                    }
                }
                if (win > lose)
                {
                    dailyMoney += dailyMoney * 0.10;
                    daysWon++;
                }
                else
                {
                    daysLost++;
                }
                moneyEarned += dailyMoney;

            }
            if (daysWon > daysLost)
            {
                moneyEarned += moneyEarned * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyEarned:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyEarned:f2}");
            }
        }
    }
}
