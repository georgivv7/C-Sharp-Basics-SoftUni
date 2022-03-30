using System;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int home = 0;
            int away = 0;
            int countWin = 0;
            int countDraw = 0;
            int countLose = 0;

            for (int i = 1; i <= 3; i++)
            {
                string match = Console.ReadLine();
                home = match[0];
                away = match[2];

                if (home>away)
                {
                    countWin++;
                }
                else if (away>home)
                {
                    countLose++;
                }
                else if (home==away)
                {
                    countDraw++;
                }
            }
            Console.WriteLine($"Team won {countWin} games.");
            Console.WriteLine($"Team lost {countLose} games.");
            Console.WriteLine($"Drawn games: {countDraw}");
        }
    }
}
