using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your target: ");
            int target = int.Parse(Console.ReadLine());

            int start = 0;
            while(start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
