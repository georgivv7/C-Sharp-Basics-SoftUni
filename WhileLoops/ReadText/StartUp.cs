﻿using System;

namespace ReadText
{
    class StartUp
    {
        static void Main(string[] args)
        {  
            while (true)
            {
                string text = Console.ReadLine();
               
                if (text=="Stop")
                {
                    break;
                }
                Console.WriteLine(text);
            }
            
        }
    }
}
