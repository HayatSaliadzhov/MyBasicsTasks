namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int projects = int.Parse(Console.ReadLine());

            int result = projects * 3;

            Console.WriteLine($"The architect {name} will need {result} hours to complete {projects} project/s.");
        }
    }
}