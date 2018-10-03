using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReadingAndWritingToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            // Concatenation
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
            // Placeholder syntax
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        }
    }
}
