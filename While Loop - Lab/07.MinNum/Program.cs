using System;

namespace _0.BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;

            string input = string.Empty;



            while ((input = Console.ReadLine()) != "Stop")
            {

                int num = int.Parse(input);




                if (num < minNum)
                {
                    minNum = num;
                }

            }

            Console.WriteLine(minNum);

        }
    }
}
