using System;

namespace Bills
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfMonths = int.Parse(Console.ReadLine());
            double sumElectricity = 0;
            double sumAll = 0;
            double average = 0;
            double waterBill = 0;
            double internetBill = 0;

            for (int i = 1; i <= numOfMonths; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                sumElectricity += electricityBill;
            }
            waterBill = numOfMonths * 20;
            internetBill = numOfMonths * 15;
            sumAll = (sumElectricity + waterBill + internetBill);
            sumAll += (sumAll * 0.20);
            average = (sumElectricity + waterBill + internetBill+sumAll) / numOfMonths;

            Console.WriteLine($"Electricity: {sumElectricity:F2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {sumAll:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
