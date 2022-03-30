using System;

namespace ChallengeTheWedding
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int males = int.Parse(Console.ReadLine());
            int females = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int dates = 0;

            for (int j = 1; j <= males; j++)
            {
                for (int k = 1; k <= females; k++)
                {
                    dates++;
                    if (dates <= tables)
                    {
                        Console.Write($"({j} <-> {k}) ");
                    }

                }
            }




        }

    }
}
