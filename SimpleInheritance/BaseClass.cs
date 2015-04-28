using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{

    class BaseClass
    {
        public  BaseClass()
        {
            Console.WriteLine("constructor BaseClass");
        }
    }
    class ChildClass : BaseClass
    {
        public  ChildClass()
        {
            Console.WriteLine("Constructor ChildClass");
        }
    }
}
