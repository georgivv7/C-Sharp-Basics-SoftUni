using System;

namespace OnTimeForExam
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examInMinutes = (examHour * 60) + examMinutes;
            int arrivalInMinutes = (arrivalHour * 60) + arrivalMinute;
           
            if (arrivalInMinutes>examInMinutes)
            {
                Console.WriteLine("Late");
                int lateInMinutes = arrivalInMinutes - examInMinutes;
                if (lateInMinutes < 60)
                {
                    Console.WriteLine($"{lateInMinutes} minutes after the start");
                }
                else    
                {
                    int lateHours = lateInMinutes / 60;
                    int lateMinutes = lateInMinutes % 60;
                    Console.WriteLine($"{lateHours}:{lateMinutes:D2} hours after the start");
                }        
            }
            else if (arrivalInMinutes==examInMinutes||examInMinutes-arrivalInMinutes<=30)
            {
                Console.WriteLine("On time");
                if (arrivalInMinutes!=examInMinutes)
                {
                    Console.WriteLine($"{examInMinutes - arrivalInMinutes} minutes before the start");
                }
            }
            else if (examInMinutes-arrivalInMinutes>30)
            {
                Console.WriteLine("Early");
                int earlyInminutes = examInMinutes - arrivalInMinutes;
                if (earlyInminutes<60)
                {
                    Console.WriteLine($"{earlyInminutes} minutes before the start");
                }
                else
                {
                    int earlyHour = earlyInminutes / 60;
                    int earlyMinutes = earlyInminutes % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinutes:D2} hours before the start");
                }
            }
            



        }
    }
}
