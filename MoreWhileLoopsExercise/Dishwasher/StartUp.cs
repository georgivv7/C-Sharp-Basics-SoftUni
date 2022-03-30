using System;

namespace Dishwasher
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int detergent = bottles * 750;
            string command = string.Empty;
            int counter = 0;
            int sumPlates = 0;
            int sumPots = 0;
            int detergentLeft = detergent;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    int pots = int.Parse(command);
                    sumPots += pots;
                    detergentLeft -= (pots * 15);
                }
                else
                {
                    int plates = int.Parse(command);
                    sumPlates += plates;
                    detergentLeft -= (plates * 5);
                }
                if (detergentLeft < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergentLeft)} ml. more necessary!");
                    return;
                }
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{sumPlates} dishes and {sumPots} pots were washed.");
            Console.WriteLine($"Leftover detergent {detergentLeft} ml.");





        }
    }
}
