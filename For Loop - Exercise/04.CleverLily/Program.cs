namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int savedMoney = 0;
            int giftedMoney = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    savedMoney += toyPrice;

                }
                else
                {
                    savedMoney += giftedMoney - 1;
                    giftedMoney += 10;
                }

            }
            double diff = Math.Abs(washingMachine - savedMoney);
            if (savedMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}