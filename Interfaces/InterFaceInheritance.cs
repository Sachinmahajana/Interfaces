using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //interface inheriting each other
    //interface 1 declare here
    interface I1
    {
         void print();
    }
    //interface 2 declare here
    interface I2
    {
         void print2();
    }
    //interface3 declare here and inherit with each other
    interface I3:I1,I2
    {
         void print3();
    }
   public  class Programs: I3
   {
        public void print()
        {
            Console.WriteLine("These is the I1 interface method");
        }  
        public void print2()
        {
            Console.WriteLine("These is the I2 interface method");
        }
        public void print3()
        {
            Console.WriteLine("These is the I3 interface method");
        }
    }

}
