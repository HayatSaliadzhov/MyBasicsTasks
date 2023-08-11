namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fee = 0;

            for (int i = 0; i < n; i++)
            {
                string openTabs = Console.ReadLine();

                if (openTabs == "Facebook")
                {
                    fee += 150;
                }
                else if (openTabs == "Instagram")
                {
                    fee += 100;
                }
                else if (openTabs == "Reddit")
                {
                    fee += 50;
                }
            }

            if (fee >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - fee);
            }
        }
    }
}