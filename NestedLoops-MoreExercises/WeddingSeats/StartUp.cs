using System;

namespace WeddingSeats
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numOfRowsFirstSector = int.Parse(Console.ReadLine());
            int numOfOddRows = int.Parse(Console.ReadLine());
            int numOfEvenRows = numOfOddRows + 2;
            int asciiCode = 96;
            int numOfPlaces = 0;
            for (char firstSector = 'A'; firstSector <= lastSector; firstSector++)
            {
                for (int rows = 1; rows <= numOfRowsFirstSector; rows++)
                {                 
                    if (rows%2!=0)
                    {
                        for (char place = 'a'; place <= asciiCode+numOfOddRows; place++)
                        {
                            numOfPlaces++;
                            Console.WriteLine($"{firstSector}{rows}{place}");
                            
                        }
                    }
                    else if(rows%2==0)
                    {
                        for (char place = 'a'; place <= asciiCode+numOfEvenRows ; place++)
                        { 
                            numOfPlaces++;
                            Console.WriteLine($"{firstSector}{rows}{place}");
                        }
                    }
                                                        
                }
                numOfRowsFirstSector++;
                
            }
            Console.WriteLine($"{numOfPlaces}");
        }
    }
}
