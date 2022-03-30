using System;

namespace TrapezoidArea
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double lice = ((b1 + b2) * h) / 2;
            Console.WriteLine($"{lice:f2}");
        }
    }
}
