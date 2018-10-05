using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNum = int.Parse(Console.ReadLine());

            switch (userNum)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;
            }

            // OR

            switch (userNum)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", userNum);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 & 30");
                    break;
            }

            // Coffee Shop Menu

            int totalCoffeeCost = 0;

            Start:
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
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    break;
            }

            Decision:
            Console.Write("Do you want to buy another coffee - Yes or No? ");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToLower())
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again..", userDecision);
                    goto Decision;
            }

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }
    }
}
