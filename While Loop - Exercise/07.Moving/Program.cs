using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int cubicMeters = width * length * height;
            int totalRoom = 0;

            while (cubicMeters >= 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }
                else
                {
                    int roomTaken = int.Parse(input);
                    cubicMeters -= roomTaken;
                }

            }
            if (cubicMeters < totalRoom)
            {
                int roomNeeded = totalRoom - cubicMeters;
                Console.WriteLine($"No more free space! You need {roomNeeded} Cubic meters more.");
            }
            else
            {
                int roomLeft = cubicMeters - totalRoom;
                Console.WriteLine($"{roomLeft} Cubic meters left.");
            }
        }
    }
}
