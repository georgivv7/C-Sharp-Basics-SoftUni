using System;

namespace GodzillaVsKong
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfStatist = int.Parse(Console.ReadLine());
            double priceForCostume = double.Parse(Console.ReadLine());

  
            double sumCostume = priceForCostume * numOfStatist;
            budget -= 0.10 * budget;
            if (numOfStatist>150)
            {
                sumCostume -= sumCostume * 0.10;
          
            }

            budget -= sumCostume;
            
            if (budget>=0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget):f2} leva more.");
            }
            
        }
    }
}
