using System;

namespace SumOFTwoNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magicNum)
                    {
                        start = i;
                        end = j;
                        break;
                    }
                }
                if (sum == magicNum)
                {
                    break;
                }


            }
            if (sum == magicNum)
            {
                Console.WriteLine($"Combination N:{counter} ({start} + {end} = {magicNum})");

            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }

        }
    }
}
