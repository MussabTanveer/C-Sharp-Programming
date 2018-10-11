using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        // base class method hiding by new keyword
        public new void printFullName()
        {
            // to call the base class method
            base.printFullName();
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }

    public class PartTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "FullTime";
            FTE.lastName = "Employee";
            FTE.printFullName();
            // To only call the base class hidden method
            // cast child type to parent type
            ((Employee)FTE).printFullName();

            // Or simply create parent class reference variable pointing to child class object
            Employee FTE2 = new FullTimeEmployee();
            FTE2.firstName = "FullTime";
            FTE2.lastName = "Employee2";
            FTE2.printFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "PartTime";
            PTE.lastName = "Employee";
            PTE.printFullName();
        }
    }
}
