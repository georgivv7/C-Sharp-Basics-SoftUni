using System;

namespace PrimePairs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int firstStart = int.Parse(Console.ReadLine());
            int secondStart = int.Parse(Console.ReadLine());
            int firstEnd = int.Parse(Console.ReadLine());
            int secondEnd = int.Parse(Console.ReadLine());
            firstEnd += firstStart;
            secondEnd += secondStart;
            for (int i = firstStart; i <=firstEnd ; i++)
            {
                for (int j = secondStart; j <= secondEnd; j++)
                {
                    bool isPrimei = true;
                    bool isPrimej = true;
                    for (int k = 2; k <= Math.Sqrt(i); k++)
                    {
                        if (i%k==0)
                        {
                            isPrimei = false;
                            break;
                        }
                    }
                    for (int l = 2; l <= Math.Sqrt(j) ; l++)
                    {
                        if (j%l==0)
                        {
                            isPrimej = false;
                            break;
                        }
                    }
                    if (isPrimei&&isPrimej)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    
                }
            }
        }
    }
}
