using System;

namespace Journey
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            double moneySpent = 0;
            string vacation1 = "Camp";
            string vacation2 = "Hotel";

            if (budget<=100)
            {
                if (season == "summer")
                {
                    moneySpent = budget * 0.30;
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"{vacation1} - {moneySpent:f2}");
                }
                else
                {
                    moneySpent = budget * 0.70;
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"{vacation2} - {moneySpent:f2}");
                }
              
            }
            else if (budget>100&&budget<=1000)
            {
                if (season=="summer")
                {
                    moneySpent = budget * 0.40;
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"{vacation1} - {moneySpent:f2}");
                }
                else
                {
                    moneySpent = budget * 0.80;
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"{vacation2} - {moneySpent:f2}");
                }
            }
            else
            {
                moneySpent = budget * 0.90;
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"{vacation2} - {moneySpent:f2}");
            }        
            
            

        }
    }
}
