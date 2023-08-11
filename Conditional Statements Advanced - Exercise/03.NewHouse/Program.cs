using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

           
            double finalPrice = 0;

            if (flower == "Roses")
            {
                finalPrice = 5 * flowerCount;

                if (flowerCount > 80)
                {
                    finalPrice = finalPrice - finalPrice * 0.1;
                }
            }
            else if (flower == "Dahlias")
            {
                finalPrice = 3.8 * flowerCount;
                if (flowerCount > 90)
                {
                    finalPrice = finalPrice - finalPrice * 0.15;
                }
            }
            else if (flower == "Tulips")
            {
                finalPrice = 2.8 * flowerCount;
                if (flowerCount > 80)
                {
                    finalPrice = finalPrice - finalPrice * 0.15;
                }
            }
            else if (flower == "Narcissus")
            {
                finalPrice = 3 * flowerCount;
                if (flowerCount < 120)
                {
                    finalPrice = finalPrice + finalPrice * 0.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                finalPrice = 2.5 * flowerCount;
                if (flowerCount < 80)
                {
                    finalPrice = finalPrice + finalPrice * 0.2;
                }
            }
            

            if (budget >= finalPrice)
            {
                double remainingMoney = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {remainingMoney:f2} leva left.");
            }
            else 
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
            


        }
    }
}
