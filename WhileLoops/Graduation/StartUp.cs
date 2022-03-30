using System;

namespace Graduation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumMarks = 0;
            int grade = 0;

            while (true)
            {
                double yearMark = double.Parse(Console.ReadLine());
                sumMarks += yearMark;
                grade++;
                if (yearMark<4)
                {
                    yearMark = double.Parse(Console.ReadLine());
                    if (yearMark<4)
                    {
                        
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }
                if (grade == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {sumMarks / 12:f2}");
                    break;
                }
            }
            
        }
    }
}
