using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;
            string newBook = Console.ReadLine();

            while (newBook != "No More Books")
            {
                
                if (newBook == book)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                newBook = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
