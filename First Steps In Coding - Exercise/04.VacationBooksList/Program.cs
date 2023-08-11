namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesNum = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int total = pagesNum / pages / days;

            Console.WriteLine(total);
        }
    }
}