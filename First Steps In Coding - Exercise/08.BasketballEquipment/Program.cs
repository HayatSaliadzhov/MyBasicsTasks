namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyFee = int.Parse(Console.ReadLine());

            double sneakers = yearlyFee - (yearlyFee * 0.4);
            double clothing = sneakers - (sneakers * 0.2);
            double ball = clothing * 1 / 4;
            double accessories = ball * 1 / 5;

            double totalCosts = yearlyFee + sneakers + clothing + ball + accessories;

            Console.WriteLine(totalCosts);
        }
    }
}