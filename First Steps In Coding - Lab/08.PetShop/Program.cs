namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodDog = int.Parse(Console.ReadLine());
            int foodCat = int.Parse(Console.ReadLine());
            double value = (foodDog * 2.50) + (foodCat * 4);

            Console.WriteLine($"{value} lv.");

        }
    }
}