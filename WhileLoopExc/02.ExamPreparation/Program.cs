using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblems = 0;
            double gradesSum = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;

            while (failedTimes < badGrades)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedProblems++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
