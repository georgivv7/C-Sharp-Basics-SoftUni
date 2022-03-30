using System;

namespace ToyShop
{
    class StartUp
    {
        static void Main(string[] args)
        {

            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleQuantity = int.Parse(Console.ReadLine());
            int dollQuantity = int.Parse(Console.ReadLine());
            int bearQuantity = int.Parse(Console.ReadLine());
            int minionQuantity = int.Parse(Console.ReadLine());
            int truckQuantity = int.Parse(Console.ReadLine());

            double AllSum = puzzleQuantity*2.60 + dollQuantity*3 + bearQuantity*4.10 + minionQuantity*8.20 + truckQuantity*2;
            int sumQuantity = puzzleQuantity + dollQuantity + bearQuantity + minionQuantity + truckQuantity;

            if (sumQuantity>=50)
            {
                AllSum -= AllSum*0.25;
            }

            AllSum -= AllSum * 0.10;
            
            if (AllSum>=vacationPrice)
            {
                Console.WriteLine($"Yes! {AllSum-vacationPrice:f2} lv left.");
            }

            else
            {

                Console.WriteLine($"Not enough money! {vacationPrice-AllSum:f2} lv needed.");
            }

        }
    }
}
