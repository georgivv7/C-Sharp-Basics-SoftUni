    using System;

    namespace WorldSwimmingRecord
    {
        class StartUp
        {
            static void Main(string[] args)
            {
                double worldRecord = double.Parse(Console.ReadLine());
                double distanceInMetres = double.Parse(Console.ReadLine());
                double timeInSeconds = double.Parse(Console.ReadLine());

                double sumTime = distanceInMetres * timeInSeconds;
                double resistance = Math.Floor(distanceInMetres / 15)*12.5;
                double totalTime = sumTime + resistance;

           
                if (totalTime<worldRecord)
                {
                    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
                }
                else 
                {
                    Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:f2} seconds slower.");
                }
            

            }
        }
    }
