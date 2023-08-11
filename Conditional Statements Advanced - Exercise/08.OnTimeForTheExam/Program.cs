using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHr = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHr = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            //
            int arrivalMins = (arrivalHr * 60) + arrivalMin;
            int examMins = (examHr * 60) + examMin;
            int diffArivalTime = examMins - arrivalMins;
            //
            if (diffArivalTime < 0)// Late
            {
                Console.WriteLine("Late");
                diffArivalTime = Math.Abs(diffArivalTime);
                if (diffArivalTime < 60)
                {
                    Console.WriteLine($"{diffArivalTime} minutes after the start");
                }
                else if (diffArivalTime >= 60)
                {
                    int diffArivalHr = diffArivalTime / 60;
                    int diffArivalMin = diffArivalTime % 60;
                    Console.WriteLine($"{diffArivalHr}:{diffArivalMin:d2} hours after the start");
                }
            }
            else if (diffArivalTime >= 0 && diffArivalTime <= 30)// On time
            {
                Console.WriteLine("On time");
                if (diffArivalTime != 0)
                {
                    Console.WriteLine($"{diffArivalTime} minutes before the start");
                }
            }
            else if (diffArivalTime > 30)//Early
            {
                Console.WriteLine("Early");
                if (diffArivalTime < 60)
                {
                    Console.WriteLine($"{diffArivalTime} minutes before the start");
                }
                else
                {
                    int diffArivalHr = diffArivalTime / 60;
                    int diffArivalMin = diffArivalTime % 60;
                    Console.WriteLine($"{diffArivalHr}:{diffArivalMin:d2} hours before the start");
                }
            }
        }
    }
}
