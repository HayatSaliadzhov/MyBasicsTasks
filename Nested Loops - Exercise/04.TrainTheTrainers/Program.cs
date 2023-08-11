using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            
            double sum = 0;
            int presentationCounter = 0;  
     
            while (presentation != "Finish")
            {
                double grade = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    grade += double.Parse(Console.ReadLine());
                      
                }
                grade = grade / n;
                sum += grade;
                
                Console.WriteLine($"{presentation} - {grade:f2}.");
                presentationCounter++;
                presentation = Console.ReadLine();
                
            }
            
            Console.WriteLine($"Student's final assessment is {sum / presentationCounter:f2}.");
           
        }
       
        
        
        
    }
}
