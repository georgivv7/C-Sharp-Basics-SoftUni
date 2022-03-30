using System;

namespace TradeCommissions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percent = -1;
            

            if (city=="Sofia")
            {
                if (sales>=0&&sales<=500)
                {
                    percent = 0.05;
                }
                else if (sales>500&&sales<=1000)
                {
                    percent = 0.07;
                }
                else if (sales>1000&&sales<=10000)
                {
                    percent = 0.08;
                }
                else if (sales>1000)
                {
                    percent = 0.12;
                }   
            }
            else if (city=="Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percent = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percent = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percent = 0.10;
                }
                else if (sales > 1000)
                {
                    percent = 0.13;
                }
            }
            else if (city=="Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percent = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percent = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percent = 0.12;
                }
                else if (sales > 1000)
                {
                    percent = 0.145;
                }
            }
            if (percent>=0)
            {
                Console.WriteLine($"{sales * percent:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
