using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int graphicCard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int graphicCardCost = graphicCard * 250;

            double processorPrice = (0.35 * graphicCardCost);
            double processorCost = processor * processorPrice;

            double ramPrice = (0.1 * graphicCardCost);
            double ramCost = ramPrice * ram;


            double total = graphicCardCost + ramCost + processorCost;

            if ( graphicCard > processor)
            {
                total = total - 0.15 * total; 
            }

            if (budget >= total)
            {
                double left = budget - total;
                Console.WriteLine($"You have {left:f2} leva left!");
            }
            else
            {
                double left = total - budget;
                Console.WriteLine($"Not enough money! You need {left:f2} leva more!");
            }
        } 
	

	
    }
}
