using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryNum = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            for (int i = 0; i < juryNum; i++)
            {
                string juryName = Console.ReadLine();
                double givenPoints = double.Parse(Console.ReadLine());
                int len = juryName.Length;
                totalPoints = academyPoints;
                academyPoints += ((len * givenPoints) / 2);
                if (academyPoints >= 1250.5)
                {
                    break;
                }
                
               
            }
            if (academyPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
            }
            else
            {
                double pointsNeeded = 1250.5 - academyPoints;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }



        }
    }
}
