using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double grades = 0;
            int badGrades = 0;

            while (grade <= 12)
            {
                double newGrade = double.Parse(Console.ReadLine());
                if (newGrade < 4)
                {
                    badGrades++;

                    if (badGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    continue;
                }
                grade++;
                grades += newGrade;
            }
            if (grades > 4)
            {
                double averageGrades = grades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrades:f2}");
            }


        }
    }
}