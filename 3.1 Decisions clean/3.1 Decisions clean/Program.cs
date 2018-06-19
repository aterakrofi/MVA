using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Decisions_clean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3 : ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a car!";       // No curly braces because there is only one line of code
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else     // Catch all if none of the conditions are true
            {
                message = " Sorry, we didn't understand.";

            }

            Console.WriteLine(message);
            Console.ReadLine();


        }
    }
}