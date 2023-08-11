namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paintLitres = int.Parse(Console.ReadLine());
            int diluentLitres = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumMaterials = ((nylon + 2) * 1.50);
            double sumLitres = (paintLitres * 14.50) * 1.1;
            double sumDiluent = diluentLitres * 5;

            double totalMaterials = sumDiluent + sumLitres + sumMaterials + 0.4;
            double totalWorkers = (totalMaterials * 0.3) * hours;

            double totalAmount = totalMaterials + totalWorkers;

            Console.WriteLine($"Total amount:{totalAmount}");
        }
    }
}