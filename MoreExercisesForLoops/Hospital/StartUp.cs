using System;

namespace Hospital
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctor = 7;
            int treatedPatients = 0;         
            int unTreatedPatients = 0;
            int sumTreated = 0;
            int sumUntreated = 0;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (unTreatedPatients> treatedPatients && i % 3 == 0)
                {
                              
                        doctor += 1;                  
                }
                if (patients<=7)
                {
                    treatedPatients = patients;
                    sumTreated += treatedPatients;
                }
                else if (patients > 7)
                {
                    treatedPatients = doctor;
                    unTreatedPatients = patients-treatedPatients;
                    sumUntreated += unTreatedPatients;
                    sumTreated += treatedPatients;
                }
                



            }
            Console.WriteLine($"Treated patients: {sumTreated}.");
            Console.WriteLine($"Untreated patients: {sumUntreated}.");
        }
    }
}
