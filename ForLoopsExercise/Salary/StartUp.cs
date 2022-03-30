using System;

namespace Salary
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int salaryRemaining = salary;

            for (int i = 0; i <numTabs; i++)
            {
                string website = Console.ReadLine();
                switch (website)
                {
                    case "Facebook":
                        salaryRemaining -= 150;
                        break;
                    case "Instagram":
                        salaryRemaining -= 100;
                        break;
                    case "Reddit":
                        salaryRemaining -= 50;
                        break;
                }
               

            }
            if (salaryRemaining<=0)
            {               
                Console.WriteLine("You have lost your salary.");
            }
            else if(salary==salaryRemaining)
            {
                Console.WriteLine($"{salary}");
            }
            else
            {
                Console.WriteLine($"{salaryRemaining}");
            }

        }
    }
}
