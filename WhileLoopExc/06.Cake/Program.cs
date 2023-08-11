using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int pieces = length * width;
            int totalPieces = 0;


            while (pieces >= 0)
            {
                
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    int takenPieces = int.Parse(input);
                    pieces -= takenPieces;

                }
                

            }
            if (pieces < totalPieces)
            {
                int neededPieces = totalPieces - pieces;
                Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
            }
            else
            {
                
                int leftPieces = pieces - totalPieces;
                Console.WriteLine($"{leftPieces} pieces are left.");
            }
        }
    }
}
