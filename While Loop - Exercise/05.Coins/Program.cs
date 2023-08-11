using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int count = 0;

            while (input > 0)
            {
                if (input >= 2)
                {
                    input -= 2;
                }
                else if (input >= 1)
                {
                    input -= 1;
                }
                else if (input >= 0.5)
                {
                    input -= 0.5;
                }
                else if (input >= 0.2)
                {
                    input -= 0.2;
                }
                else if (input >= 0.1)
                {
                    input -= 0.1;
                }
                else if (input >= 0.05)
                {
                    input -= 0.05;
                }
                else if (input >= 0.02)
                {
                    input -= 0.02;
                }
                else if (input >= 0.01)
                {
                    input -= 0.01;
                }
                input = Math.Round(input, 2);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
