using System;

namespace Firm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double workDays = 0.9 * availableDays;
            double overtimeHours = overtimeWorkers * (2 * availableDays);
            double workingHours = workDays * 8;
            double totalHours = Math.Floor(overtimeHours + workingHours);

            double hoursLeft = Math.Abs(totalHours - projectHours);
            if (totalHours>=projectHours)
            {
                
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursLeft} hours needed.");
            }

        }
    }
}
