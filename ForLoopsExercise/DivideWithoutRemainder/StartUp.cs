using System;

namespace DivideWithoutRemainder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double numberCounter1 = 0;
            double numberCounter2 = 0;
            double numberCounter3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    numberCounter1++;
                    p1 = (numberCounter1 / n) * 100;
                }
                if (num%3==0)
                {
                    numberCounter2++;
                    p2 = (numberCounter2 / n) * 100;
                }
                if (num%4==0)
                {
                    numberCounter3++;
                    p3 = (numberCounter3 / n) * 100;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
