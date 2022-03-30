using System;

namespace CatWalking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int minWalk = int.Parse(Console.ReadLine());
            int numOfWalks = int.Parse(Console.ReadLine());
            int caloriesIn = int.Parse(Console.ReadLine());

            int caloriesOut = (minWalk * numOfWalks) * 5;
            double fiftyPerc = caloriesIn * 0.50;

            if (caloriesOut>=fiftyPerc)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesOut}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesOut}.");
            }

        }
    }
}
