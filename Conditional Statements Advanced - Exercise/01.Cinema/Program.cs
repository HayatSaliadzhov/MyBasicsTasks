using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (movieType == "Premiere")
            {
                income = rows * columns * 12.00;

            }
            else if (movieType == "Normal")
            {
                income = rows * columns * 7.5;
            }
            else if (movieType == "Discount")
            {
                income = rows * columns * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
