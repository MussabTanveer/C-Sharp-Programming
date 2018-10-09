using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_StaticAndInstanceClassMembers
{
    class Circle
    {
        // static field
        public static float _PI;
        // instance field
        int _radius;

        // static constructor to initialize static field
        // access modifiers (public, protected, etc) are not allowed i.e it is private by default
        // must be parameterless
        // called automatically only once
        static Circle()
        {
            Console.WriteLine("Inside static constructor");
            Circle._PI = 3.141F;
        }

        // instance constructor to initialize an instance field
        public Circle(int radius)
        {
            Console.WriteLine("Inside instance constructor");
            this._radius = radius;
        }

        // instance method
        public float calculateArea()
        {
            return Circle._PI * this._radius * this._radius;
        }

        // static method
        public static void Print()
        {
            //
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // static public field accessed using name of class
            // Before printing value of PI, static constructor will be called
            Console.WriteLine(Circle._PI);

            Circle C1 = new Circle(5);
            // instance method invoked using object of class
            float area = C1.calculateArea();
            Console.WriteLine("Area = {0}", area);

            Circle C2 = new Circle(6);
            // instance method invoked using object of class
            float area2 = C2.calculateArea();
            Console.WriteLine("Area = {0}", area2);

            // static method invoked using name of class
            Circle.Print();
        }
    }
}
