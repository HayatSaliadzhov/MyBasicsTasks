using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysIn = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();
            double totalCosts = 0;
            if (roomType == "room for one person")
            {
                totalCosts = daysIn - 1 * 18;
                if (grade == "Positive")
                {
                    totalCosts = totalCosts + (totalCosts * 0.25);
                }
                else if (grade == "Negative")
                {
                    totalCosts = totalCosts - (totalCosts * 0.1);
                }

            }
            else if (roomType == "apartment")
            {
                totalCosts = daysIn - 1 * 25;

            }
        }
    }
}
