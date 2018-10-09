using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Classes
{
    class Customer
    {
        string _firstName;
        string _lastName;

        // Default Constructor
        public Customer() : this("No first name provided", "No last name provided")
        {

        }

        // Parameterized Constructor
        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        // Print attributes
        public void printFullName()
        {
            Console.WriteLine("Full Name: " + this._firstName + " " + this._lastName);
        }

        // Destructor
        ~Customer()
        {
            // clean up code
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.printFullName();

            Customer C2 = new Customer("John", "Doe");
            C2.printFullName();
        }
    }
}
