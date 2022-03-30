using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxYear = int.Parse(Console.ReadLine());

            double priceShoes = taxYear - (taxYear * 0.40);
            double priceEquip = priceShoes - (priceShoes * 0.20);
            double priceBall = priceEquip * 1 / 4;
            double priceAccsesories = priceBall * 1 / 5;
            double sum = taxYear + priceAccsesories + priceBall + priceEquip + priceShoes;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
