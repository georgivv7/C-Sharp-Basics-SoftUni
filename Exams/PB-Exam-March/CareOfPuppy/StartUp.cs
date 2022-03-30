using System;

namespace CareOfPuppy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            int foodInGr = foodInKg * 1000;
            string command = string.Empty;
            int sumEaten = 0;
            while (true)
            {
                command =Console.ReadLine();
                if (command == "Adopted")
                {
                    break;
                }
                int foodEaten = int.Parse(command);
                sumEaten += foodEaten;             
            }
            if (sumEaten <= foodInGr)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGr - sumEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sumEaten - foodInGr} grams more.");
            }

        }
    }
}
