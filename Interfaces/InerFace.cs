using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Create the interface class
    interface IEmployee 
    {
        //Declare the function 
        void show();
    }
       // Create another interface
    interface IEmployee2
    {
        //Declare 2 function
        void show2();
    }
        // We are implemented in derived class two interface
        // and implemented multiple inheritance
    class PartTimeEmployee:IEmployee,IEmployee2
    {
        public void show()
        {
            Console.WriteLine("This is a method of IEmployee Interface");
        }
        public void show2()
        {
            Console.WriteLine("This is the Second interface method");
        }
    }
}
