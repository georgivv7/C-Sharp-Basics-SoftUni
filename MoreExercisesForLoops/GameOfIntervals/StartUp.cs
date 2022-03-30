using System;

namespace GameOfIntervals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            double countTo9 = 0;
            double countTo19 = 0;
            double countTo29 = 0;
            double countTo39 = 0;
            double countTo50 = 0;
            double countInvalid = 0;
            double percent0to9 = 0;
            double percent10to19 = 0;
            double percent20to29 = 0;
            double percent30to39 = 0;
            double percent40to50 = 0;
            double percentInvalid = 0;
            for (int i = 1; i <=n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num>=0&&num<=9)
                {
                    countTo9 += 1;
                    result += 0.2 * num;
                }
                if (num>=10&&num<=19)
                {
                    countTo19 += 1;
                    result += 0.3 * num;
                }
                if (num>=20&&num<=29)
                {
                    countTo29 += 1;
                    result += 0.4 * num;

                }
                if (num>=30&&num<=39)
                {
                    countTo39 += 1;
                    result += 50;
                }
                if (num>=40&&num<=50)
                {
                    countTo50 += 1;
                    result += 100;
                   
                }
                if (num<0||num>50)
                {
                    countInvalid += 1;
                    result= result / 2;
                    
                }
                percent0to9 = (countTo9 / n) * 100;
                percent10to19 = (countTo19 / n) * 100;
                percent20to29 = (countTo29 / n) * 100;
                percent30to39 = (countTo39 / n) * 100;
                percent40to50 = (countTo50 / n) * 100;
                percentInvalid = (countInvalid / n) * 100;
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {percent0to9:f2}%");
            Console.WriteLine($"From 10 to 19: {percent10to19:f2}%");
            Console.WriteLine($"From 20 to 29: {percent20to29:f2}%");
            Console.WriteLine($"From 30 to 39: {percent30to39:f2}%");
            Console.WriteLine($"From 40 to 50: {percent40to50:f2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");
        }
    }
}
