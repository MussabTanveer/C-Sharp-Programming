using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            Console.WriteLine(name);

            // Escape Sequences
            name = "\"John\"";
            Console.WriteLine(name);

            name = "One\nTwo\nThree";
            Console.WriteLine(name);

            name = "C:\\Users\\Spectacular\\Documents\\Visual Studio 2015\\Projects\\C# Tutorials";
            Console.WriteLine(name);

            // Verbatim Literal
            name = @"C:\\Users\\Spectacular\\Documents\\Visual Studio 2015\\Projects\\C# Tutorials";
            Console.WriteLine(name);

            name = @"C:\Users\Spectacular\Documents\Visual Studio 2015\Projects\C# Tutorials";
            Console.WriteLine(name);
        }
    }
}
