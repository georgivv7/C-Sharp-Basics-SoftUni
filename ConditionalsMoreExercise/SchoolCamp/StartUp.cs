using System;

namespace SchoolCamp
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numOfStudents = int.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());

            string sport = "";
            double price = 0;

            switch (typeOfGroup)
            {
                case "boys":
                case "girls":
                    if (season=="Winter")
                    {
                        if (typeOfGroup == "boys")
                        {
                            sport = "Judo";
                        }
                        else if (typeOfGroup == "girls") 
                        {
                            sport = "Gymnastics";
                        }                         
                        price = numOfNights * 9.60 * numOfStudents;
                        if (numOfStudents>=50)
                        {
                            price -= price * 0.50;
                        }
                        else if (numOfStudents>=20&&numOfStudents<50)
                        {
                            price -= price * 0.15;
                        }
                        else if (numOfStudents>=10&&numOfStudents<20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season=="Spring")
                    {
                        if (typeOfGroup == "boys")
                        {
                            sport = "Tennis";
                        }
                        else if (typeOfGroup == "girls")
                        {
                            sport = "Athletics";
                        }                       
                        price = numOfNights * 7.20 * numOfStudents;
                        if (numOfStudents >= 50)
                        {
                            price -= price * 0.50;
                        }
                        else if (numOfStudents >= 20 && numOfStudents < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (numOfStudents >= 10 && numOfStudents < 20)
                        {
                            price -= price * 0.05;
                        }

                    }
                    else if (season=="Summer")
                    {                                                
                        if (typeOfGroup == "boys")
                        {
                            sport = "Football";
                        }
                        else if (typeOfGroup == "girls")
                        {
                            sport = "Volleyball";
                        }
                        price = numOfNights * 15*numOfStudents;
                        if (numOfStudents >= 50)
                        {
                            price -= price * 0.50;
                        }
                        else if (numOfStudents >= 20 && numOfStudents < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (numOfStudents >= 10 && numOfStudents < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    break;
                case "mixed":
                    if (season == "Winter")
                    {
                        sport = "Ski";
                        price = numOfNights * 10 * numOfStudents;
                        if (numOfStudents >= 50)
                        {
                            price -= price * 0.50;
                        }
                        else if (numOfStudents >= 20 && numOfStudents < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (numOfStudents >= 10 && numOfStudents < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    else if (season == "Spring")
                    {
                        sport = "Cycling";
                        price = numOfNights * 9.50 * numOfStudents;
                        if (numOfStudents >= 50)
                        {
                            price -= price * 0.50;
                        }
                        else if (numOfStudents >= 20 && numOfStudents < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (numOfStudents >= 10 && numOfStudents < 20)
                        {
                            price -= price * 0.05;
                        }

                    }
                    else if (season == "Summer")
                    {
                        sport = "Swimming";
                        price = numOfNights * 20 * numOfStudents;
                        if (numOfStudents >= 50)
                        {
                            price -= price * 0.50;
                        }
                        else if (numOfStudents >= 20 && numOfStudents < 50)
                        {
                            price -= price * 0.15;
                        }
                        else if (numOfStudents >= 10 && numOfStudents < 20)
                        {
                            price -= price * 0.05;
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
