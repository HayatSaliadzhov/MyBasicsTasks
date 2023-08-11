namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volumeCm = length * width * height;
            //Console.WriteLine($"The volume is: {volumeCm} cubic centimetres.");

            double volumeLtr = volumeCm * 0.001;
            //Console.WriteLine($"The volume in litres is: {volumeLtr} litres.");

            double percentages = percentage / 100;
            //Console.WriteLine($"The aquarium has {percentages} of used space.");

            double neededLtr = volumeLtr * (1 - percentages);

            Console.WriteLine($"Needed liters for filling up the aquarium are: {neededLtr} liters.");
        }
    }
}