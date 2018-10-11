using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parameterless ParentClass Constructor Called");
        }

        public ParentClass(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived Class controlling Parent Class")
        {
            Console.WriteLine("ChildClass Constructor Called");
        }
    }

    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public void printFullName()
        {

        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }

    // multi level class inheritance allowed
    public class A : PartTimeEmployee
    {

    }

    // multiple class inheritance not allowed
    /*public class B : Employee, A
    {

    }*/

    public class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "John";
            FTE.lastName = "Doe";
            FTE.email = "john@example.com";
            FTE.yearlySalary = 50000;
            FTE.printFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Jane";
            PTE.lastName = "Doe";
            PTE.email = "jane@example.com";
            PTE.hourlyRate = 50000;
            PTE.printFullName();

            A A1 = new A();
        }
    }
}
