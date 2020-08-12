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

            string myLastname;
            Console.Write("Type your last name: ");
            myLastname = Console.ReadLine();

            Console.WriteLine("Hello, {0} {1}", myFirstName, myLastname);
        }
    }
}
