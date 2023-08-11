using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0.0;
            double apartment = 0.0;
            if (month == "May" || month == "October")
            {
                studio = 50;
                    apartment = 65;
               
                if (nights < 14 && nights > 7)
                {
                    studio *= 0.95;
                }
                else if (nights >= 14)
                {
                    studio *= 0.7;
                    apartment *= 0.9;
                }
                
               
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.2;
                apartment = 68.7;
               
                if (nights > 14)
                {
                    studio *= 0.8;
                    apartment *= 0.9;
                 
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;

                if (nights > 14)
                {
                    studio = 76;
                    apartment *= 0.9;
                }
            }
            double totalCostsApartment = apartment * nights;
            double totalCostsStudio = studio * nights;
            Console.WriteLine($"Apartment: {totalCostsApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalCostsStudio:f2} lv.");
        }
    }
}
