using System;

namespace _04.ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int puppets = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totals = puppets * 3 + puzzles * 2.60 + bears * 4.10 + minions * 8.2 + trucks * 2;
            int totalToys = puppets + puzzles + bears + minions + trucks;
            
                 if (totalToys >= 50)
            {
                totals = totals - 0.25 * totals;
            }
            totals = totals - 0.1 * totals;
            if (totals >= trip)
            {
                totals = totals - trip;
              
                Console.WriteLine($"Yes! {totals:F2} lv left.");
            }
            else
            {
                totals = trip - totals;
               
                Console.WriteLine($"Not enough money! {totals:F2} lv needed. ");
            }
        

        }
    }
}
