using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int numOfJury = int.Parse(Console.ReadLine());
            double sum = pointsAcademy;
            for (int i = 1; i <= numOfJury; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                sum += (name.Length * points) / 2;
                if (sum > 1250.5)
                {
                    break;
                }
            }
            if (sum > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {sum:F1}!");
            }
            else
            {
                sum -= 1250.5;
                Console.WriteLine($"Sorry, {actor} you need {Math.Abs(sum):F1} more!");
            }
        }
    }
}
