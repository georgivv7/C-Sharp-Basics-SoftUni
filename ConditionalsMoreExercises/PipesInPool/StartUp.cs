using System;

namespace PipesInPool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

           
            double firstPipe = P1 * H;
            double secondPipe = P2 * H;
            double sumPipes = firstPipe + secondPipe;

            if (sumPipes<=V)
            {
                double capacityIn = (sumPipes / V) * 100;
                double capacityFirst = (firstPipe / sumPipes) * 100;
                double capacitySecond = (secondPipe / sumPipes) * 100;
                Console.WriteLine($"The pool is {capacityIn:f2}% full. Pipe 1: {capacityFirst:f2}%. Pipe 2: {capacitySecond:f2}%.");
            }
            else 
            {
                double capacityMore = sumPipes - V;
                Console.WriteLine($"For {H} hours the pool overflows with {capacityMore:f2} liters.");
            }
        }
    }
}
