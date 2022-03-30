using System;

namespace _06.FavouriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int limit = 0;
            double asciiSum = 0;
            double maxSum = 0;
            string bestMovie = "";
            while (true)
            {
                if (input == "STOP")
                {
                    break;
                }
                limit++;
                if (limit == 7)
                {
                    break;
                }
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLower(input[i]))
                    {
                        asciiSum += input[i] - input.Length * 2;
                    }
                    else if (char.IsUpper(input[i]))
                    {
                        asciiSum += input[i] - input.Length;
                    }
                    else
                    {
                        asciiSum += input[i];
                    }
                }
                if (asciiSum > maxSum)
                {
                    maxSum = asciiSum;
                    bestMovie = input;
                }
                asciiSum = 0;
                input = Console.ReadLine();
            }
            if (limit == 7)
            {
                Console.WriteLine("The limit is reached.");
                Console.WriteLine($"The best movie for you is {bestMovie} with {maxSum} ASCII sum.");
            }
            if (input == "STOP")
            {
                Console.WriteLine($"The best movie for you is {bestMovie} with {maxSum} ASCII sum.");
            }
        }
    }
}
