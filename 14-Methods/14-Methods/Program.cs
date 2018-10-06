using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            // Instance method
            p.evenNumbers(20);

            // Static method
            evenNumbersStatic(20);

            // Instance method
            int sum = p.add(2, 3);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Sum = {0}", p.add(9, 6));
        }

        public void evenNumbers(int target)
        {
            int start = 0;
            while(start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        public static void evenNumbersStatic(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        public int add(int fn, int sn)
        {
            return fn + sn;
        }
    }
}
