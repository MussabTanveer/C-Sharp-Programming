using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = new int[3];
            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            //Console.WriteLine(evenNumbers[1]);

            int[] marks = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(marks[2]);

            int[] qty = { 1, 2, 3, 4, 5 };
            Console.WriteLine(qty[2]);

            int[] students = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(students[2]);
        }
    }
}
