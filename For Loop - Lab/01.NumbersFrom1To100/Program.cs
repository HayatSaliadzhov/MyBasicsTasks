using System;

namespace _01.NumbersFrom1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int nominator = int.Parse(Console.ReadLine());

            double totalPoints = 0;
            for (int i = 0; i < nominator && totalPoints > 1250.5 ; i++)
            {
                string nominatorName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                for (int a = 0; a < nominatorName.Length; a++)
                {
                   
                }

            }
            
            if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints} more!");
            }
        }
    }
}
