using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game!");

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("What city were you born in? ");
            string city = Console.ReadLine();

            DisplayResult(
                ReverseString(firstName), 
                ReverseString(lastName),
                ReverseString(city));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
            //allows outiside values to be used insde the method
        {
            char[] messageArray = message.ToCharArray();
            // creates an array of chars from message
            Array.Reverse(messageArray);
            // reverses the order of the characters in the array
            return String.Concat(messageArray);
            // uses string helper method to concatenate the characters in the array
        }

        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}", 
                reversedFirstName, 
                reversedLastName, 
                reversedCity));
        }
    }
}
