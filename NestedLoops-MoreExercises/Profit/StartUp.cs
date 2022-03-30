using System;

namespace Profit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int monets1lev = int.Parse(Console.ReadLine());
            int monets2lev = int.Parse(Console.ReadLine());
            int banknotes5lev = int.Parse(Console.ReadLine());
            int sumAll = int.Parse(Console.ReadLine());

            for (int i = 0; i <= monets1lev; i++)
            {
                for (int j = 0; j <= monets2lev; j++)
                {
                    for (int k = 0; k <= banknotes5lev; k++)
                    {
                        if (i*1+j*2+k*5==sumAll)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sumAll} lv.");
                        }
                    }
                }
                
            }


        }
            
    }
}
