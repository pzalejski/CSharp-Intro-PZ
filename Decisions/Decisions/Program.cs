using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter's Big Giveaway!");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue =="1")
            {
                message = "You won a new car!";
            }
            else if (userValue =="2")
            {
                message = "You won free lunch!";
            }
            else if (userValue == "3")
            {
                message = "You won a new boat!";
            }
            else
            {
                message = "Sorry, I don't understand.";
            }
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
