using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            // Value parameters
            simpleMethod1(i);
            Console.WriteLine(i);

            // Reference parameters
            simpleMethod2(ref i);
            Console.WriteLine(i);

            // Out parameters
            int total = 0;
            int product = 0;
            calculate2(10, 20, out total, out product);
            Console.WriteLine("Sum = {0}, Product = {1}", total, product);

            // Parameter arrays
            int[] numbers = { 101, 102, 103 };
            // must pass an array
            withoutParamsMethod(numbers);
            // without parameter array
            paramsMethod();
            // with parameter array
            paramsMethod(numbers);
            // with parameter variable
            paramsMethod(i);
            paramsMethod(1, 2, 3, 4, 5);
            // value & array params
            paramsMethod2(1, 2);
            paramsMethod2(1, 2, 3, 4);
        }

        // Pass by value
        public static void simpleMethod1(int j)
        {
            j = 101;
        }

        // pass by reference
        public static void simpleMethod2(ref int j)
        {
            j = 101;
        }

        // return 1 value
        public static int calculate1(int fn, int sn)
        {
            return fn + sn;
        }

        // return more than 1 value
        public static void calculate2(int fn, int sn, out int sum, out int product)
        {
            sum = fn + sn;
            product = fn * sn;
        }

        // without parameter arrays
        // need to pass an array
        public static void withoutParamsMethod(int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        // parameter arrays
        // optional to pass an array
        public static void paramsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        // value parametrs & parameter arrays
        // parameter array must be the last one
        public static void paramsMethod2(int x, int y, params int[] numbers)
        {
            Console.WriteLine("x is {0}", x);
            Console.WriteLine("y is {0}", y);
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
