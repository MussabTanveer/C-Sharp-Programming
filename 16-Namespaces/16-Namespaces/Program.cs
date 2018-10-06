using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // using namespace fully qualified name
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();

            // using namespace alias directives
            PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
    }
}

/*
 * ProjectA
 * TeamA
 * TeamB
*/

/*
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print method");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print method");
            }
        }
    }
}
*/
