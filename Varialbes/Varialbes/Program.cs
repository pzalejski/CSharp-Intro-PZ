using System;

namespace Varialbes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();
            // ReadLine retreives data from the end user, which is then assigned to the variable myFirstName

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine(); //this is called initializiation combines what was done above in less lines


            Console.WriteLine("Hello, {0} {1}", myFirstName, myLastName);
        }
    }
}
