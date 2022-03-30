using System;

namespace _06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int start = target - 30;
            int fail = 0;
            int total = 0;
            while (start <= target)
            {
                int currentJump = int.Parse(Console.ReadLine());
                total++;
                if (currentJump > start)
                {
                    start += 5;
                    fail = 0;
                }
                else
                {
                    fail++;
                }
                if (fail == 3)
                {
                    break;
                }
            }
            if (fail == 3)
            {
                Console.WriteLine($"Tihomir failed at {start}cm after {total} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {target}cm after {total} jumps.");
            }
        }
    }
}
