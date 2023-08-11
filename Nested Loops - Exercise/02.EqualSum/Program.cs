using System;

namespace _02.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int oddNum = 0;
                int evenNum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenNum += currentDigit;
                    }
                    else
                    {
                        oddNum += currentDigit;
                    }
                }
                if (oddNum == evenNum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
