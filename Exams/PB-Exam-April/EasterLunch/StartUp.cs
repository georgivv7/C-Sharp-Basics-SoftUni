using System;

namespace EasterLunch
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfKozunak = int.Parse(Console.ReadLine());
            int numOfEggs = int.Parse(Console.ReadLine());
            int kgOfKurabii = int.Parse(Console.ReadLine());

            double priceKozunak = numOfKozunak * 3.20;
            double priceEggs = numOfEggs * 4.35;
            double priceKurabii = kgOfKurabii * 5.40;
            double pricePaint = numOfEggs * 12 * 0.15;

            double allSum = priceEggs + priceKozunak + priceKurabii+pricePaint;
            Console.WriteLine($"{allSum:F2}");


        }
    }
}
