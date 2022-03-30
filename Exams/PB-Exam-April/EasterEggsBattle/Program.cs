using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsPlayer1 = int.Parse(Console.ReadLine());
            int eggsPlayer2 = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while (input != "End of battle")
            {
                input =Console.ReadLine();
                if (input=="one")
                {
                    eggsPlayer2--;
                }
                else if (input=="two")
                {
                    eggsPlayer1--;
                }
                if (eggsPlayer1 <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayer2} eggs left.");
                    break;
                }
                else if (eggsPlayer2 <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayer1} eggs left.");
                    break;
                }
            }
            
            if (input=="End of battle")
            {
                Console.WriteLine($"Player one has {eggsPlayer1} eggs left.");
                Console.WriteLine($"Player two has {eggsPlayer2} eggs left.");
            }
        }
    }
}
