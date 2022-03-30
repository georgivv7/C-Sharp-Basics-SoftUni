using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int points = 0;
            int charLetter = 0;
            int maxPoints = 0;
            string maxName = "";
            while (input!="Stop")
            { 
                
                points = 0;
                for (int i = 0 ; i < input.Length; i++)
                {
                    charLetter = input[i];
                    int number = int.Parse(Console.ReadLine());                  
                    if (number==charLetter)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                    if (points >= maxPoints)
                    {
                        maxPoints = points;
                        maxName = input;
                    }
                }
                input =Console.ReadLine();
            }
            Console.WriteLine($"The winner is {maxName} with {maxPoints} points!");
        }
    }
}
