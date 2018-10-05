using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            else if (userNum == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            else
            {
                Console.WriteLine("Your number is neither one nor two.");
            }

            if(userNum == 10 || userNum == 20)
            {
                Console.WriteLine("Your number is ten or twenty.");
            }

            if (userNum == 10 && userNum == 20)
            {
                Console.WriteLine("Your number is ten and twenty.");
            }
        }
    }
}
