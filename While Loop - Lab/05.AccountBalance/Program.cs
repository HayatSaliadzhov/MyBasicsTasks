using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double balance = 0;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double currentSum = double.Parse(input);
                if (currentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += currentSum;
                Console.WriteLine($"Increase: {currentSum:f2}");
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
