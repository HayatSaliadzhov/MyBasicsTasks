using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0, nonPrimeSum = 0;

            string input = Console.ReadLine();
            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    double sqrt = Math.Sqrt(number);
                    for (int i = 2; i <= sqrt && isPrime; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        primeSum += number; 

                    }
                    else
                    {
                        nonPrimeSum += number;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            
        }
    }
}
