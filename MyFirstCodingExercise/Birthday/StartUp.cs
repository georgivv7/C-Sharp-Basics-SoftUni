using System;

namespace Birthday
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());
            double PriceForCake = rentForHall * 0.2;
            double PriceForDrinks = PriceForCake-(PriceForCake*0.45);
            double PriceForAnimator = rentForHall/3;

            double Sum = rentForHall + PriceForCake + PriceForDrinks + PriceForAnimator;
            Console.WriteLine(Sum);

        }
    }
}
