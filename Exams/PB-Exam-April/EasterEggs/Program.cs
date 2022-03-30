using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int orange = 0;
            int red = 0;
            int blue = 0;
            int green = 0;
            for (int i = 1; i <= paintedEggs; i++)
            {
                input = Console.ReadLine();
                if (input=="red")
                {
                    red++;
                }
                else if (input=="orange")
                {
                    orange++;
                }
                else if (input == "blue")
                {
                    blue++;
                }
                else if (input == "green")
                {
                    green++;
                }
            }
            int maxEggs = green;
            string color = "green";
            if (red>maxEggs)
            {
                maxEggs = red;
                color = "red";
            }
            if (blue>maxEggs)
            {
                maxEggs = blue;
                color = "blue";
            }
            if (orange>maxEggs)
            {
                maxEggs = orange;
                color = "orange";
            }
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {color}");
        }
    }
}
