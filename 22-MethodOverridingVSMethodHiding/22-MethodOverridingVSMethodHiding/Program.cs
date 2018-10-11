using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_MethodOverridingVSMethodHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print method");
        }

        public virtual void Print2()
        {
            Console.WriteLine("I am a Base Class Print2 method");
        }
    }

    public class DerivedClass : BaseClass
    {
        // Method Overriding
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class Print method");
        }

        // Method Hiding
        public new void Print2()
        {
            Console.WriteLine("I am a Derived Class Print2 method");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // reference variable of base class pointing to child class object
            BaseClass B = new DerivedClass();
            B.Print(); // call overridden child class method
            B.Print2(); // call hidden base class method

            DerivedClass D = new DerivedClass();
            D.Print2();
        }
    }
}
