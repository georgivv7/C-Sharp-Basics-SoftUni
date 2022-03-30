using System;

namespace EqualPairs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double difference = 0;
            double sum = 0;
            double lastSum = 0;
            for (int i = 1; i <= n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                sum = num1 + num2;
                if (i>1)
                {
                    difference = lastSum - sum;
                    difference = Math.Abs(difference);
                }
                lastSum = sum;
                
            }
            if (difference==0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else if(difference!=0)
            {
                Console.WriteLine($"No, maxdiff={difference}");
            }
        }
    }
}
