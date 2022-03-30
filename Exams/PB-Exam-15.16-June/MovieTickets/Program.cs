using System;

namespace MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int symbol4 = 0;
            for (int symbol1 = a1; symbol1 <= a2-1; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= n-1; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= n/2-1; symbol3++)
                    {
                        symbol4 = symbol1;
                        double sum = symbol2 + symbol3 + symbol4;

                        if (symbol1 % 2 != 0 && sum % 2 != 0)
                        {
                             char firstSymbol = Convert.ToChar(symbol1);
                             Console.WriteLine($"{firstSymbol}-{symbol2}{symbol3}{symbol4}");
                        }
                    }
                }
            }
        }
    }
}
