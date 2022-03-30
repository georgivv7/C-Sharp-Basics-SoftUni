using System;

namespace LoadSuitcase
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityOfTrunk = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "End")
            {              
                double suitcase = double.Parse(input);
                counter++;
                if (counter % 3 == 0)
                {
                    suitcase = suitcase * 0.10 + suitcase;
                }
                if (suitcase>capacityOfTrunk)
                {
                    counter--;
                    break;
                }            
                capacityOfTrunk -= suitcase;
                input =Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine($"No more space!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
        
    }
}
