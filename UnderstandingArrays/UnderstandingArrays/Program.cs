using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[5];
            // an array of intergers 
            // array that can hold 5 values, 5 integers 


            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //console.write(numbers.length);
            //console.readline();

            int[] numberss = new int[] { 4, 5, 15, 16, 23, 42 };
            // doing like so, will allow the compiler figure out how many elements are in the array

            string[] names = new string[] { "Tom", "Mike", "Sam", "Joe" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();


            string zig = "You can get what you want out of life" + 
                " if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

        }
    }
}
