using System;

namespace _05.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decorations = 0.1 * budget;
            double totalClothing = clothingPrice * statists;

            if (statists > 150)
            {
                totalClothing = totalClothing - 0.1 * totalClothing;
                
            }
            
            double totalCosts = decorations + totalClothing;

            if (totalCosts > budget)
            {
                budget = totalCosts - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {budget:F2} leva more.");
            }
            else
            {
                budget = budget - totalCosts;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:F2} leva left.");

            }
        }

    }
}
