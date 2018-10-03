
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CommonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment operator
            int i = 10;
            bool b = true;

            // Arithmetic operators
            int numerator = 10;
            int denominator = 2;
            int result = numerator / denominator;
            Console.WriteLine("Result = {0}", result);
            int remainder = numerator % denominator;
            Console.WriteLine("Remainder = {0}", remainder);

            // Comparison operators
            int number = 10;
            if(number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            if (number != 10)
            {
                Console.WriteLine("Number is 10");
            }

            // Conditional operators
            int secondNumber = 20;
            if (number == 10 && secondNumber == 20)
            {
                Console.WriteLine("Hello");
            }
            if (number == 10 || secondNumber == 30)
            {
                Console.WriteLine("Hello");
            }

            // Ternary operators
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", isNumber10);
        }
    }
}
