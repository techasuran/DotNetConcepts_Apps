using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Creating object of child class and assign to childclass object");
            ChildClass childClassObj = new ChildClass();

            Console.WriteLine("\n\n");

            //Console.WriteLine("Creating object of child class and assigning to baseclass object");
            BaseClass baseClassObj = new ChildClass();

            Console.ReadLine();

        }
    }
}
