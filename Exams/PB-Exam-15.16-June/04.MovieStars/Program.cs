using System;

namespace _04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "ACTION")
                {
                    break;
                }
                
                if (input.Length<=15)
                {
                    double salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                }
                else
                {
                    budget -= budget * 0.20;
                }
                if (budget < 0)
                {
                    break;
                }
                input =Console.ReadLine();
            }
            if (budget>0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");              
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }

        }
    }
}
