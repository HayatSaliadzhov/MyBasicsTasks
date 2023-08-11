namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int totalPeople = 0;

            for (int i = 0; i < n; i++)
            {
                int countOfPeople = int.Parse(Console.ReadLine());
                if (countOfPeople <= 5)
                {
                    p1 += countOfPeople;
                }
                else if (countOfPeople <= 12)
                {
                    p2 += countOfPeople;
                }
                else if (countOfPeople <= 25)
                {
                    p3 += countOfPeople;
                }
                else if (countOfPeople <= 40)
                {
                    p4 += countOfPeople;
                }
                else
                {
                    p5 += countOfPeople;
                }
                totalPeople += countOfPeople;
            }
            Console.WriteLine($"{(double)p1 / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)p2 / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)p3 / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)p4 / totalPeople * 100:f2}%");
            Console.WriteLine($"{(double)p5 / totalPeople * 100:f2}%");
        }
    }
}