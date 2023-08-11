using System;

namespace _04.Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int goal = 10000;
            int stepsCounter = 0;

            while (stepsCounter <= goal)
            {

                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int LastNum = int.Parse(Console.ReadLine());
                    stepsCounter += LastNum;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    stepsCounter += steps;
                }
                


                

            }
            if (stepsCounter >= goal)
            {
                int totalStepsOver = stepsCounter - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalStepsOver} steps over the goal!");
            }
            else
            {
                int stepsNeeded = goal - stepsCounter;
                Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
            }
        }
    }
}
