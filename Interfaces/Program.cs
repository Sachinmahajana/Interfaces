namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the interface");
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.show();
            pte.show2();
        }
    }
}