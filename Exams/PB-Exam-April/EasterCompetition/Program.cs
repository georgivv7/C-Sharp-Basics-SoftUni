using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            string chef = string.Empty;
            string input = string.Empty;
            int maxValue = int.MinValue;
            string maxChef = "";
            int points = 0;
            for (int i = 1; i <= easterBread; i++)
            {
                chef = Console.ReadLine();
                points = 0;
                while (true)
                {
                    input =Console.ReadLine();
                    if (input=="Stop")
                    {
                        Console.WriteLine($"{chef} has {points} points.");
                        if (points>maxValue)
                        {
                            maxValue = points;
                            maxChef = chef;
                            Console.WriteLine($"{maxChef} is the new number 1!");
                        }                                                                 
                        break;
                    }
                    int mark = int.Parse(input);
                    points += mark; 
                    
                }
                
            }
            Console.WriteLine($"{maxChef} won competition with {maxValue} points!");
        }

    }
}
