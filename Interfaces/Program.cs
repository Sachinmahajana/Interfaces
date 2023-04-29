namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the interface");
            Console.WriteLine("Select the Program given below");
            Console.WriteLine("\n1:Interface\n2:Interfaceinheritance");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PartTimeEmployee pte = new PartTimeEmployee(); 
                    pte.show();
                    pte.show2();
                    break;
                case 2:
                    //Programs program = new Programs();
                    //program.print();
                    //program.print2();
                    //program.print3();
                    // reference variable of parent class I3
                    I3 myinterface = new Programs();
                    myinterface.print();
                    myinterface.print2();
                    myinterface.print3();
                    break;
                default:
                    Console.WriteLine("Please select program given below");
                    break;
            }
        }
    }
}