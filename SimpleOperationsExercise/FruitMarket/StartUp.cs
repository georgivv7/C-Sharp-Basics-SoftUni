using System;

namespace FruitMarket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const double oneEuro = 1.94;

            double vegetablesPricePerKg = double.Parse(Console.ReadLine());
            double fruitsPricePerKg = double.Parse(Console.ReadLine());
            int allKgVegetables = int.Parse(Console.ReadLine());
            int allKgFruits = int.Parse(Console.ReadLine());

            double vegetables = vegetablesPricePerKg * allKgVegetables;
            double fruits = fruitsPricePerKg * allKgFruits;
            double TotalSum = (vegetables + fruits)/oneEuro;

            Console.WriteLine($"{TotalSum:f2}");
        }
    }
}
