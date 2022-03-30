using System;

namespace SumOfTwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int numberMagic = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    counter++;
                    sum = i + j;
                    if (sum == numberMagic)
                    {
                        number1 = i;
                        number2 = j;
                        break;
                    }


                }
                if (sum == numberMagic)
                {
                    break;
                }
            }
            if (sum == numberMagic)
            {
                Console.WriteLine($"Combination N:{counter} ({number1} + {number2} = {numberMagic})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {numberMagic}");
            }

        }
    }
}
