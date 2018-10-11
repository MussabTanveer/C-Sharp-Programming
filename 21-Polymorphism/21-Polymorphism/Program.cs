using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Polymorphism
{
    // polymorphism allows to invoke derived class methods through a base class reference during runtime

    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        // to override the method in derived class, make the method virtual in base class
        public virtual void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        // use override keyword to override the method implementation by base class
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Full Time");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Part Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        // provide no overriden method implementation so base class method will get invoked
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee();
            E.printFullName();

            // Array of Employees
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.printFullName();
            }
        }
    }
}
