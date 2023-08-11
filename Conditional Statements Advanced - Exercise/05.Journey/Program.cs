using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string stay = "";
            double moneySpent = 0;
            if (budget <= 100)
            {
                
                destination  = "Bulgaria";
                if (season == "summer")
                {
                    stay = "Camp";
                    moneySpent= budget - (budget - budget * 0.3);
                }
                else if (season == "winter")
                {
                    stay = "Hotel";
                    moneySpent = budget - (budget - budget * 0.7);
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    stay = "Camp";
                    moneySpent = budget - (budget - budget * 0.4);
                }
                else if (season == "winter")
                {
                    stay = "Hotel";
                    moneySpent = budget - (budget - budget * 0.8) ;
                }
            }
            else 
            {
                
                destination = "Europe";
                stay = "Hotel";
                moneySpent = budget - (budget - budget * 0.9);
            }
            

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stay} - {moneySpent:f2}");
        }
    }
}
