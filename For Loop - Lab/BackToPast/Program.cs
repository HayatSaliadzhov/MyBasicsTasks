using System;

namespace BackToPast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritage = double.Parse(Console.ReadLine());
            int livingYear = int.Parse(Console.ReadLine());
            int startYear = 18;
            int costs = 0;
            
            for (int i = 1800; i <= livingYear; i++)
            {
                if ( i % 2 == 0)
                {
                    costs = 12000;
                    inheritage -= costs;

                }
                else
                {
                    startYear++;
                    costs = (12000 + (50 * (startYear)));
                    inheritage -= costs;
                   
                   
                }
            }
            if (costs < inheritage )
            {
                
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritage:f2} dollars left.");
            }
            else
            {
                
                Console.WriteLine($"He will need {Math.Abs(inheritage):f2} dollars to survive.");
            }
        }
    }
}
