using System;

namespace SumSeconds
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());

            int totalTime = seconds1 + seconds2 + seconds3;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds<10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
