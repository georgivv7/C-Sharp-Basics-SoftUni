using System;

namespace _04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 =Console.ReadLine();
            string player2 =Console.ReadLine();
            double points1 = 0;
            double points2 = 0;
            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End of game")
                {
                    Console.WriteLine($"{player1} has {points1} points");
                    Console.WriteLine($"{player2} has {points2} points");
                    break;
                }
                int cardPlayer1 = int.Parse(input);
                input =Console.ReadLine();
                int cardPlayer2 = int.Parse(input);
                if (cardPlayer1>cardPlayer2)
                {
                    points1 += cardPlayer1 - cardPlayer2;
                }
                else if (cardPlayer2>cardPlayer1)
                {
                    points2 += cardPlayer2 - cardPlayer1;
                }
                else if (cardPlayer1==cardPlayer2)
                {
                    Console.WriteLine($"Number wars!");
                    cardPlayer1 = int.Parse(Console.ReadLine());
                    cardPlayer2 = int.Parse(Console.ReadLine());
                    if (cardPlayer1>cardPlayer2)
                    {
                        Console.WriteLine($"{player1} is winner with {points1} points");
                    }
                    else
                    {
                        Console.WriteLine($"{player2} is winner with {points2} points");
                    }
                    break;
                }
               
            }
            
        }
    }
}
