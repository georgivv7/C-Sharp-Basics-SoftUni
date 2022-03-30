using System;

namespace Vacation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int spendingCount = 0;

            while (availableMoney<neededMoney&&spendingCount<5)
            {
                countDays++;
                string action = Console.ReadLine();
                double sumMoney = double.Parse(Console.ReadLine());
                

                if (action=="spend")
                {
                    spendingCount ++;
                    availableMoney -= sumMoney;
                    if (availableMoney<0)
                    {
                        availableMoney = 0;
                    }
                    if (spendingCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{countDays}");

                    }
                }
                else if (action=="save")
                {
                    spendingCount = 0;
                    availableMoney += sumMoney; 
                }
                
            }           
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");

            }

        }
    }
}
