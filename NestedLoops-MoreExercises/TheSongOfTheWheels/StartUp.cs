using System;

namespace TheSongOfTheWheels
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());
            int counter = 0;
            string password = null;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {

                            if (controlValue == a * b + c * d && a < b && c > d)
                            {

                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;
                                if (counter==4)
                                {
                                    password = $"{a}{b}{c}{d}";
                                }
                            }  
                           
                        }
                    }
                }
            }
            if (counter>0)
            {
                Console.WriteLine();
            }
            if (password!=null)
            {
                Console.WriteLine($"Password: {password}");
            }
            if (counter < 4)
            {
                Console.Write("No!");
            }
        }
    }
}
