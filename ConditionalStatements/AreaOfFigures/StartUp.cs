using System;

namespace AreaOfFigures
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double lenght = double.Parse(Console.ReadLine());

            if (figure=="square")
            {
                Console.WriteLine(Math.Round(lenght*lenght,3));
            }
            else if (figure=="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(lenght*width,3));
            }
            else if (figure=="circle")
            {
                Console.WriteLine(Math.Round(Math.PI*(lenght*lenght),3));
            }
            else if (figure=="triangle")
            {
                double strana = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(lenght*strana/2,3));
            }
        }
    }
}
