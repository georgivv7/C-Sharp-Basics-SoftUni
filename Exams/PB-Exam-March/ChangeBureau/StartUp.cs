using System;

namespace ChangeBureau
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfBitcoins = int.Parse(Console.ReadLine());
            double numOfChinese = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double levaBit = numOfBitcoins * 1168;
            double chineseDol = numOfChinese * 0.15;
            double levDol = chineseDol * 1.76;
            double euroSum = levaBit + levDol;
            euroSum /= 1.95;
            double sum = (euroSum * commission) / 100;
            double result = euroSum - sum;

            Console.WriteLine($"{result:f2}");

        }
    }
}
