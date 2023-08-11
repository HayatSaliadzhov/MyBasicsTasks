namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litresCleaner = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());

            double total = (pen * 5.80) + (markers * 7.20) + (litresCleaner * 1.20);
            double price = total - (total * 0.25);

            Console.WriteLine(price);
        }
    }
}