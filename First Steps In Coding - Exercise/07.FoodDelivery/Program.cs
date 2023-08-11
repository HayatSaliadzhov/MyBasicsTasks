namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenNum = int.Parse(Console.ReadLine());
            int fishNum = int.Parse(Console.ReadLine());
            int veggieNum = int.Parse(Console.ReadLine());


            double totalChicken = chickenNum * 10.35;
            double totalFish = fishNum * 12.40;
            double totalveggie = veggieNum * 8.15;

            double totalFood = totalChicken + totalFish + totalveggie;
            double sweets = totalFood * 0.2;
            double totalCosts = totalFood + sweets + 2.5;

            Console.WriteLine($"The total cost of the order is: {totalCosts}.");
        }
    }
}