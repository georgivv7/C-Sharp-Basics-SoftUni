using System;

namespace FoodForCats
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            double quantityFood = double.Parse(Console.ReadLine());
            double sumEaten = 0;
            double sumEatenDog = 0;
            double sumEatenCat = 0;
            double biscuits = 0;
            for (int i = 1; i <= numOfDays; i++)
            {
                double eatenDog = double.Parse(Console.ReadLine());
                sumEatenDog += eatenDog;
                double eatenCat = double.Parse(Console.ReadLine());
                sumEatenCat += eatenCat;

                if (i%3==0)
                {
                    double currentBiscuits = (eatenDog + eatenCat) * 0.10;
                    biscuits += currentBiscuits;
                }
            }
            sumEaten = sumEatenDog + sumEatenCat;
            double percentEaten = sumEaten / quantityFood * 100;
            double percentDog = sumEatenDog / sumEaten * 100;
            double percentCat = sumEatenCat / sumEaten * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentEaten:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:f2}% eaten from the cat.");

        }
    }
}
