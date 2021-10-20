using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Reflection
{

    class Dynamic_Object
    {
        public Dynamic_Object() { }
        public Dynamic_Object(String msg) { }

        public void First_Method() {
            Console.WriteLine("Inside First Method");
        }
        
        public void Second_Method() {
            Console.WriteLine("Inside Second Method");
        }
    }
}