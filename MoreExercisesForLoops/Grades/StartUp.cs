using System;

namespace Grades
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            double sumAverage = 0;
            double sumSlab = 0;
            double sumSreden = 0;
            double sumDobur = 0;
            double sumMnDobur = 0;
            double CountSlab = 0;
            double CountSreden= 0;
            double CountDobur = 0;
            double CountMnDobur = 0;
          
           
            for (int i = 1; i <= numOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade<3)
                {
                    CountSlab += 1;
                    sumSlab += grade;                   
                }
                if (grade>=3.00&&grade<=3.99)
                {
                    CountSreden += 1;
                    sumSreden += grade;
                }
                if (grade>=4.00&&grade<=4.99)
                {
                    CountDobur += 1;
                    sumDobur += grade;
                }
                if (grade>=5.00)
                {
                    CountMnDobur += 1;
                    sumMnDobur += grade;
                }
                sumAverage = (sumSlab + sumSreden + sumDobur + sumMnDobur)/numOfStudents;
            }
            double percentSlab = (CountSlab / numOfStudents) * 100;
            double percentSreden = (CountSreden / numOfStudents) * 100;
            double percentDobur = (CountDobur / numOfStudents) * 100;
            double percentMnDobur = (CountMnDobur / numOfStudents) * 100;

            Console.WriteLine($"Top students: {percentMnDobur:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentDobur:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentSreden:f2}%");
            Console.WriteLine($"Fail: {percentSlab:f2}%");
            Console.WriteLine($"Average: {sumAverage:f2}");
        }
    }
}
