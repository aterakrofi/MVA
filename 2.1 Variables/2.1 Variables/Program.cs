using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;   // camelcase
            //Console.Write("Type your last name: ");  ---------> wordy
            //myLastName = Console.ReadLine();

            //Declaring variables as needed reduces long code
            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();   // initialization

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
      
        }
    }
}
