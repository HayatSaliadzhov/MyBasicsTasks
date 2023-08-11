using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double finalPrice = 0;
            if (season == "Spring")
            {
                finalPrice = 3000;
                if (fisherman <= 6)
                {

                    finalPrice = finalPrice - finalPrice * 0.1;
                }
                
                else if (fisherman > 7 && fisherman <= 11)
                {
                    finalPrice = finalPrice - finalPrice * 0.15;
                }
                else if (fisherman >= 12)
                {
                    finalPrice = finalPrice - finalPrice * 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                finalPrice = 4200;
                if (fisherman <= 6)
                {
                    finalPrice = finalPrice - finalPrice * 0.1;
                }
                else if (fisherman > 7 && fisherman <= 11)
                {
                    finalPrice = finalPrice - finalPrice * 0.15;
                }
                else if (fisherman >= 12)
                {
                    finalPrice = finalPrice - finalPrice * 0.25;
                }
            }
            else if (season == "Winter")
            {
                finalPrice = 2600;
                if (fisherman <= 6)
                {
                    finalPrice = finalPrice - finalPrice * 0.1;
                }
                else if (fisherman > 7 && fisherman <= 11)
                {
                    finalPrice = finalPrice - finalPrice * 0.15;
                }
                else if (fisherman >= 12)
                {
                    finalPrice = finalPrice - finalPrice * 0.25;
                }
            }


            if (fisherman % 2 == 0 && season != "Autumn")
            {
                finalPrice = finalPrice - finalPrice * 0.05;
            }

            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left." );
            }
            else
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
