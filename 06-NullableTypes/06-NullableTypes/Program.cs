using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            // int i = null;
            int? i = null;

            // bool areYouMajor = null;
            bool? areYouMajor = null;
            if(areYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (areYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer");
            }

            
            int? ticketsOnSale = null;
            int availableTickets = 10;
            if(ticketsOnSale == null)
            {
                availableTickets = 0;
            }
            else
            {
                availableTickets = ticketsOnSale.Value;
                // OR
                availableTickets = (int)ticketsOnSale;
            }
            Console.WriteLine("Available Tickets = {0}", availableTickets);

            // Null Coalescing operator
            availableTickets = ticketsOnSale ?? 0; // if ticketsOnSale is null then availableTickets = 0 otherwise availableTickets = ticketsOnSale
        }
    }
}
