using System;

namespace Graduation2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 0;
            double sumMarks = 0;

            while (true)
            {
                double yearMark = double.Parse(Console.ReadLine());
                sumMarks += yearMark;
                grade++;               
            }




        }
    }
}
