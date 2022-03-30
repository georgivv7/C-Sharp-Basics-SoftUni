using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double veggieMenu = double.Parse(Console.ReadLine());
            double bill = 0;

            double priceChicken = chickenMenu * 10.35;
            double priceFish = fishMenu * 12.40;
            double priceVeg = veggieMenu * 8.15;
            double menus = priceChicken + priceFish + priceVeg;
            double priceDessert = 0.20 * menus;
            bill = menus + priceDessert + 2.50;
            Console.WriteLine($"Total: {bill:F2}");
        }
    }
}
