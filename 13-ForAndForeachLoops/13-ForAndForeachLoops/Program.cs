using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForAndForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach(int j in numbers)
            {
                Console.WriteLine(j);
            }

            for(int k = 1; k <= 20; k++)
            {
                if (k % 2 == 1)
                    continue;
                Console.WriteLine(k);
                if (k == 10)
                    break;
            }
        }
    }
}
