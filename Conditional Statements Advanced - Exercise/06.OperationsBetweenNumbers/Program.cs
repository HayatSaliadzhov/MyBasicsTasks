using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if ((operation == '/'|| operation == '%') && Num2 == 0)
            {
                Console.WriteLine($"Cannot divide {Num1} by zero");
            }
            else
            {
                if (operation == '/')
                {
                    double division = (double) Num1 / Num2;
                    Console.WriteLine($"{Num1} / {Num2} = {division:f2}");
                }
                else if (operation == '%' )
                {
                    int remainer = Num1 % Num2;
                    Console.WriteLine($"{Num1} % {Num2} = {remainer}");
                }
                else
                {
                    int result = 0;
                    if (operation == '+')
                    {
                        result = Num1 + Num2;
                    }
                    else if (operation == '-')
                    {
                        result = Num1 - Num2;
                    }
                    else if (operation == '*')
                    {
                        result = Num1 * Num2;
                    }
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{Num1} {operation} {Num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{Num1} {operation} {Num2} = {result} - odd");
                    }
                }

                
            }
        }
    }
}
