using System;

namespace _06.SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double totalSeconds = distance * time;
            double total = Math.Floor(distance / 15) * 12.5;
            double totalTime = totalSeconds + total;
            
            if (totalTime < record)
            {
                
               
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");

            }
            else
            {
                double requiredTime = totalTime - record;
                Console.WriteLine($"No, he failed! He was {requiredTime:F2} seconds slower.");
            }
        }
    }
}
