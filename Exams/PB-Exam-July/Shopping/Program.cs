using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double priceVideo = 250 * videocard;
            double priceProcessor = priceVideo * 0.35*processor;
            double priceRam = priceVideo * 0.10*ram;
            double sum = priceVideo + priceRam + priceProcessor;
            if (videocard>processor)
            {
                sum -=(sum * 0.15);
            }
            if (budget>=sum)
            {
                budget -= sum;
                Console.WriteLine($"You have {budget:f2} leva left!");
            }
            else
            {
                sum -= budget;
                Console.WriteLine($"Not enough money! You need {sum:f2} leva more!");
            }
        }
    }
}
