using System;

namespace Logistics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfCargo = int.Parse(Console.ReadLine());
            double sumOfCargo = 0;
            double averagePerTonne = 0;
            double sumWithBus = 0;
            double sumWithTruck = 0;
            double sumWithTrain = 0;
            double priceWithBus = 0;
            double priceWithTrain = 0;
            double priceWithTruck = 0;

            for (int i = 1; i <= numOfCargo; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                sumOfCargo += quantity;

                if (quantity <= 3)
                {
                    sumWithBus += quantity;
                    priceWithBus += quantity * 200;
                }
                if (quantity >= 4 && quantity <= 11)
                {
                    sumWithTruck += quantity;
                    priceWithTruck += quantity * 175;
                }
                if (quantity >= 12)
                {
                    sumWithTrain += quantity;
                    priceWithTrain += quantity * 120;
                }
            }
            averagePerTonne = (priceWithBus + priceWithTruck + priceWithTrain) / sumOfCargo;
            double percentBus = (sumWithBus / sumOfCargo) * 100;
            double percentTruck = (sumWithTruck / sumOfCargo) * 100;
            double percentTrain = (sumWithTrain / sumOfCargo) * 100;
            Console.WriteLine($"{averagePerTonne:f2}");
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");


           
        }
              
    }
}

