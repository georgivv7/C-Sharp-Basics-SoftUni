using System;

namespace StreamOfLetters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string letter = string.Empty;
            int counter = 0;
            string word = "";

            while (true)
            {
                if (letter == "End")
                {
                    break;
                }
                
                char bukva = char.Parse(letter);

                if (bukva=='c'||bukva=='o'||bukva=='n')
                {
                    counter++;
                    if (counter>1)
                    {
                        word += bukva;
                    }
                    else
                    {
                        letter = null;
                    }
                }
                switch (bukva)
                {
                    case '%':
                    case '!':
                    case '^':
                    case '`':
                    case ')':
                    case '(':
                    case '{':
                    case '}':
                    case '/':
                        letter = null;
                        break;
                }
                Console.Write(word = "" + bukva);
            }
            
        }
            
        }
 
}
