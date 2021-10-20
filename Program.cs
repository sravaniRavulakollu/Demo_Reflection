using System;
using System.Reflection;

namespace Demo_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Reflection in c#...");
            Type T = typeof(int);
            Console.WriteLine("Type of Name:{0}", T.Name);
            Console.WriteLine("Full name of the type defined :\t{0}", T.FullName);
            Console.WriteLine("Type of Assembly in which it is defined :\t {0} ", T.Assembly);
            Console.WriteLine("Information about base Type:\t{0}", T.BaseType);

            Dynamic_Object MyObj1 = new Dynamic_Object();
            MyObj1.First_Method();
            MyObj1.Second_Method();

            Dynamic_Object MyObj2 = new Dynamic_Object();
            //MyObj2.First_Method("msg from Dymanic object");
            MyObj2.Second_Method();
            MyObj2.First_Method();
        }
    }
}
