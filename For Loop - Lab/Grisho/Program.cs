using System;

namespace Grisho
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int averagePoints = 0;
            int countOfWins = 0;
            
            
            for (int i = 1; i <= tournaments; i++)
            {
                string outcome = Console.ReadLine();

                if (outcome == "W")
                {
                    totalPoints += 2000;
                }
                else if (outcome == "F")
                {
                    totalPoints += 1200;
                }
                else if (outcome == "SF")
                {
                    totalPoints += 720;
                }
                if (outcome == "W")
                {
                    countOfWins++;
                }
            }
            totalPoints += startPoints;
            averagePoints = (totalPoints - startPoints) / tournaments;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{(double)countOfWins / tournaments * 100:f2}%");
           

            
        }
    }
}
