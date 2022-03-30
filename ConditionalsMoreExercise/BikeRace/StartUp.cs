using System;

namespace BikeRace
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            
            double expenses = 0;
            double sum = 0;
            double profit = 0;

            switch (category)
            {
                case "trail":
                    sum = juniors * 5.50 + seniors * 7;
                    expenses = 0.05 * sum;
                    profit = sum - expenses;
                    break;
                case "cross-country":
                    if (juniors+seniors>=50)
                    {
                        sum = (juniors * 8 + seniors * 9.50)*0.75;
                        expenses = (0.05 *sum);
                        profit = sum - expenses;
                    }
                    else
                    {
                        sum = juniors * 8 + seniors * 9.50;
                        expenses = 0.05 * sum;
                        profit = sum - expenses;
                    }
                   
                    break;
                case "downhill":
                    sum = juniors * 12.25 + seniors * 13.75;
                    expenses = 0.05 * sum;
                    profit = sum - expenses;
                    break;
                case "road":
                    sum = juniors * 20 + seniors * 21.50;
                    expenses = 0.05 * sum;
                    profit = sum - expenses;
                    break;
            }
            Console.WriteLine($"{profit:f2}");
        }
    }
}
