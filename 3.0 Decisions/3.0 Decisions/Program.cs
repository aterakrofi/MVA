using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._0_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3 : ");
            string userValue = Console.ReadLine();

           if (userValue == "1")
            {
                string message = "You won a car!";
                Console.WriteLine(message);
            }
           else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
           else if (userValue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }
            else     // Catch all if none of the conditions are true
            {
                string message = " Sorry, we didn't understand.";
                Console.WriteLine(message);
            }

            Console.ReadLine();

        }
    }
}
