using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WritingToConsole
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("Hello C#  from Main1");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#  from Main");
            Main1();
        }
    }
}
