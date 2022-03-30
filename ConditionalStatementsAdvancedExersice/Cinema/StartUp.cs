using System;

namespace Cinema
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const double pricePremiere = 12.00;
            const double priceNormal = 7.50;
            const double priceDiscount = 5.00;

            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0;

            if (typeOfProjection=="Premiere")
            {
                income = rows * columns * pricePremiere;
            }
            else if (typeOfProjection=="Normal")
            {
                income = rows * columns * priceNormal;
            }
            else if (typeOfProjection=="Discount")
            {
                income = rows * columns * priceDiscount;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
