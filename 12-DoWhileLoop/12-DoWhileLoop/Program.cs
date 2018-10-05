using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print even numbers till user target
            string ans = "";
            do {
                Console.Write("Please enter your target: ");
                int target = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= target)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                Console.WriteLine();

                do {
                    Console.Write("Do you want to continue - Yes or No? ");
                    ans = Console.ReadLine().ToLower();

                    if (ans != "yes" && ans != "no")
                    {
                        Console.WriteLine("Invalid choice. Please say Yes or No.");
                    }
                } while (ans != "yes" && ans != "no");
            } while (ans == "yes");

            // Coffee Shop Menu
            int totalCoffeeCost = 0;
            string userDecision = "";

            do
            {
                Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        totalCoffeeCost += 1;
                        break;
                    case 2:
                        totalCoffeeCost += 2;
                        // goto case 1;
                        break;
                    case 3:
                        totalCoffeeCost += 3;
                        break;
                    default:
                        Console.WriteLine("Your choice {0} is invalid", ans);
                        break;
                }

                do {
                    Console.Write("Do you want to buy another coffee - Yes or No? ");
                    userDecision = Console.ReadLine().ToLower();

                    if (userDecision != "yes" && userDecision != "no")
                    {
                        Console.WriteLine("Invalid choice. Please say Yes or No.");
                    }
                } while (userDecision != "yes" && userDecision != "no");
            } while (userDecision == "yes");
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }
    }
}
