using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sumAscii = 0;
            decimal maxResult = 0;
            decimal charletter = 0;
            decimal result = 0;
            string mostPowerfulWord = "";
            while (input!="End of words")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    charletter = input[i];
                    sumAscii = sumAscii + charletter;

                    if (input[0]=='a'|| input[0] == 'e'|| input[0] == 'i'|| input[0] == 'o'
                        || input[0] == 'u'|| input[0] == 'y'|| input[0] == 'A'|| input[0] == 'E'||input[0]=='I'
                        || input[0] == 'O'|| input[0] == 'U'|| input[0] == 'Y')
                    {
                        result= sumAscii*input.Length;
                    }
                    else
                    {
                        result = Math.Floor(sumAscii/input.Length);
                    }
                    if (result>maxResult)
                    {
                        maxResult = result;
                        mostPowerfulWord = input;
                    }
                    
                }
                input = Console.ReadLine();
                sumAscii = 0;
                result = 0;
            }
            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {maxResult}");
        }
    }
}
