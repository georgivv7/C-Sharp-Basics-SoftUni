using System;

namespace Histogram
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double numCounter1 = 0;
            double numCounter2 = 0;
            double numCounter3 = 0;
            double numCounter4 = 0;
            double numCounter5 = 0;

            for (int i=1; i<=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                if (num<200)
                {                   
                    numCounter1++;
                    p1 = (numCounter1 / n) * 100;
                }
                
                else if (num>=200&&num<=399)
                {
                    numCounter2++;
                    p2 = (numCounter2 / n) * 100;

                }
                else if (num>=400&&num<=599)
                {
                    numCounter3++;
                    p3 = (numCounter3 / n) * 100;

                }
                else if (num>=600&&num<=799)
                {
                    numCounter4++;
                    p4 = (numCounter4 / n) * 100;

                }
                else if (num>=800)
                {
                    numCounter5++;
                    p5 = (numCounter5 / n) * 100;

                }
            }
           
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
