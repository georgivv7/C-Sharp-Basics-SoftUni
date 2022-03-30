using System;

namespace CleverLily
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toyCounter = 0;
            double savedMoney = 0;
            double presentMoney = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    savedMoney += presentMoney;
                    savedMoney--;
                    presentMoney += 10;
                }
                else
                {
                    toyCounter++;
                }
            }
            double moneyFromToys = toyCounter * toyPrice;
            savedMoney += moneyFromToys;

            if (savedMoney>=machinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney-machinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {machinePrice-savedMoney:f2}");
            }
           


        }
    }
}
