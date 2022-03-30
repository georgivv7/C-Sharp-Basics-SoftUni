using System;

namespace Walking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int sumSteps = 0;
            int target = 10000;
            while (sumSteps < target)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    int moreSteps = int.Parse(Console.ReadLine());
                    sumSteps += moreSteps;
                    break;
                }
                else
                {
                    int steps = int.Parse(command);
                    sumSteps += steps;
                }

            }
            if (sumSteps >= target)
            {
                sumSteps -= target;
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{sumSteps} steps over the goal!");

            }
            else
            {
                sumSteps = target - sumSteps;
                Console.WriteLine($"{sumSteps} more steps to reach goal.");
            }
        }
    }
}
