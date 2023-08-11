namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());

            int depositLength = int.Parse(Console.ReadLine());

            double interestPercentage = double.Parse(Console.ReadLine());

            double sum = depositSum + (depositLength * (depositSum * interestPercentage * 0.01 / 12));

            Console.WriteLine(sum);
        }
    }
}