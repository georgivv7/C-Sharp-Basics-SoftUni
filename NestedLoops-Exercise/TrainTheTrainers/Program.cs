using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string presentation = "";
            double sumMarks = 0;
            double averageMarks = 0;
            int counterMark = 0;
            while (true)
            { 
                presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {averageMarks / counterMark:f2}.");
                    break;
                }
                sumMarks = 0;
                for (int i = 1; i <= number; i++)
                {
                    double marks = double.Parse(Console.ReadLine());
                    counterMark++;
                    sumMarks += marks;
                    averageMarks += marks;
                }               
                Console.WriteLine($"{presentation} - {sumMarks/number:f2}.");                              
            }
            
        }
    }
}
