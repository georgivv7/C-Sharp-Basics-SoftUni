using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percentNonPaintable = double.Parse(Console.ReadLine());
            percentNonPaintable = percentNonPaintable/100;
            string input = Console.ReadLine(); ;
            double quadrantMeter = 0;
            double wallsLeft = 0;
            quadrantMeter = height * width * 4;
            wallsLeft = Math.Ceiling(quadrantMeter - (quadrantMeter*percentNonPaintable));
            while (input != "Tired!")
            {             
                double litersPaint = double.Parse(input);              
                wallsLeft =wallsLeft-litersPaint;
                if (wallsLeft<=0)
                {
                    break;
                }
                input =Console.ReadLine();
            }
            if (wallsLeft > 0)
            {
                Console.WriteLine($"{wallsLeft} quadratic m left.");                         
            }
            else if (wallsLeft == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
                
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(wallsLeft)} l paint left!");
            }
        }
    }
}
