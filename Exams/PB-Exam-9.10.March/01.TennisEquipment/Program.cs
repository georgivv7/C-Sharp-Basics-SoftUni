using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceRacket = double.Parse(Console.ReadLine());
            int numRackets = int.Parse(Console.ReadLine());
            int numShoes = int.Parse(Console.ReadLine());

            double racketsCost = priceRacket * numRackets;
            double shoesCost = (priceRacket/6)*numShoes;
            double sum = racketsCost + shoesCost;
            double others = sum * 0.20;
            double total = sum + others;
            double djocko = total/ 8;
            double sponsor = total * 7 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djocko)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsor)}");

        }
    }
}
