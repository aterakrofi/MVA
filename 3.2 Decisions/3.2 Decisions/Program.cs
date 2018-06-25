using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Decisions    // Useful in an if else scenario not multiple if scenarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";   // test if message equals 1, then set to first value after questions mark, if not set to the next value
                                                                               //Console.Write("You won a ");
                                                                               // Console.Write(message);
                                                                               // Console.Write(".");

            //Console.WriteLine("You won a {0}.", message);  
            //Console.WriteLine($"You won a {message} .");

            Console.WriteLine("You entered {0}, therefore you won a {1}", userValue, message);
            Console.ReadLine();
        }
    }
}
