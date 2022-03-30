using System;

namespace CharityCampaign
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const int torta = 45;
            const double gofreta = 5.80;
            const double palachinka = 3.20;
         

            int daysInCampaign = int.Parse(Console.ReadLine());
            int numOfBakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfGoffretti = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());

            double profitCake = numOfCakes * torta;
            double profitGoffretti = numOfGoffretti * gofreta;
            double profitPancake = numOfPancakes * palachinka;
          

            double sumForDay = (profitCake + profitGoffretti + profitPancake) * numOfBakers;
            double sumForCampaign = sumForDay * daysInCampaign;
            double TotalProfit = sumForCampaign - (sumForCampaign / 8);


            Console.WriteLine(TotalProfit);
            

        }
    }
}
