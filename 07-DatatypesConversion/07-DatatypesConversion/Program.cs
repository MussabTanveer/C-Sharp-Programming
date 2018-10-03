using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DatatypesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "111";
            int num = int.Parse(str);
            Console.WriteLine(num); // 111

            str = "111a";
            // num = int.Parse(str); // Exception thrown
            bool isConverted = int.TryParse(str, out num);
            Console.WriteLine(num); // 0
            Console.WriteLine("Conversion successful is {0}", isConverted);

            int i = 100;
            float f = i;
            Console.WriteLine(f); // 100

            float f2 = 123.45F;
            // int i2 = f2;
            int i2 = (int)f2;
            Console.WriteLine(i2); // 123

            float f3 = 12345678912345.45F;
            int i3 = (int)f3; // incorrect value i.e. min value of int
            Console.WriteLine(i3);
            i3 = Convert.ToInt32(f3); // exception thrown
            Console.WriteLine(i3);
        }
    }
}
