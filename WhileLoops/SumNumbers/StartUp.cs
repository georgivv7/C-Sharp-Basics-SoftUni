using System;

namespace SumNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            while (sum<number)
            {
                int currNumber = int.Parse(Console.ReadLine());              
                sum += currNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
