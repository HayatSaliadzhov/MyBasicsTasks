using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double lunch = lunchBreak * (1 / 8.0);
            double rest = lunchBreak * (1 / 4.0);
            double totalTime = lunch + rest + episodeDuration;
            
            if (totalTime <= lunchBreak)
            {
                
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(lunchBreak - totalTime)} minutes free time.");
            }
            else
            {
                
              Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(totalTime - lunchBreak)} more minutes.");
            }
        }
    }
}
