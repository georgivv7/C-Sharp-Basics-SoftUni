using System;

namespace SafePassGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            int x = 0;
            int y = 0;
            for (int i = 35; i <= 55; i++)
            {                
                for (int j = 64; j <= 96; j++)
                {
                    
                    for (x = 1; x <= a; x++)
                    {
                        for (y = 1; y <= b; y++)
                        {
                            
                            char A = ((char)i);
                            char B = ((char)j);
                            Console.Write($"{A}{B}{x}{y}{B}{A}|");
                            combinations++;
                            i++;
                            j++;                           
                            if (x == a && y == b || combinations >= maxNum)
                            {
                                return;
                            }
                            if (i > 55)
                            {
                                i = 35;
                            }
                            if (j > 96)
                            {
                                j = 64;
                            }

                        }
                        

                    }
                    
                }
                
                

            }
        }
    }
}
