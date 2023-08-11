﻿using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (fruit == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.5;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 2.7;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                        

                }
            }
            else if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.2;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.25;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                       
                }
            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 0.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 0.9;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                        
                }
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 1.45;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 1.6;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                     
                }
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 2.7;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 3.0;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                       
                }
            }
            else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 5.5;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 5.6;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                       
                }
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        price = 3.85;
                        break;
                    case "Saturday":
                    case "Sunday":
                        price = 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                        
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (price > 0)
            {
                double totalPrice = price * quantity;

                Console.WriteLine($"{totalPrice:f2}");
            }


               
            


        }
    }
}