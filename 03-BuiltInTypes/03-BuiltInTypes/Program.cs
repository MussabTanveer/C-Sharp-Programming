using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean type
            bool b = true;
            b = false;
            Console.WriteLine(b);

            // Integral types
            int i = 0;
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);

            // Floating types
            double d = 123.12345678;
            Console.WriteLine(d);

            // String type
            string str = "Hello";
            Console.WriteLine(str);
        }
    }
}
