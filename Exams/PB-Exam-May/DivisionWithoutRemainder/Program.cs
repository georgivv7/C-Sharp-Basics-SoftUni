using System;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            for (int i = 1; i <= numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    counter1++;
                }
                if (num%3==0)
                {
                    counter2++;
                }
                if(num%4==0)
                {
                    counter3++;
                }
            }
            double p1 = (counter1 / numbers) * 100;
            double p2 = (counter2 / numbers) * 100;
            double p3 = (counter3 / numbers) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
