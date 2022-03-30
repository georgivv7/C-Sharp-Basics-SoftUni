using System;

namespace EasterShop
{
    class StartUP
    {
        static void Main(string[] args)
        {
            int eggsAvailable = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int eggsSold = 0;
            while (input != "Close")
            {
                if (input=="Fill")
                {
                    int additionalEggs = int.Parse(Console.ReadLine());
                    eggsAvailable += additionalEggs;
                }
                if (input=="Buy")
                {
                    int eggPurchase = int.Parse(Console.ReadLine());
                    if (eggPurchase<=eggsAvailable)
                    {
                        eggsAvailable -= eggPurchase;
                        eggsSold += eggPurchase;
                    }
                    else
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsAvailable}.");
                        break;
                    }                  
                }
                input =Console.ReadLine();
            }
            if (input=="Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{eggsSold} eggs sold.");
            }        
        }
    }
}
