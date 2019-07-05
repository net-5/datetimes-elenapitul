using System;

namespace Fourth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Write a program to add 5 seconds to the current time and print it to the console.
            Console.WriteLine("Current time is: " + DateTime.Now);
            Console.WriteLine("Current time plus 5 seconds is: " + DateTime.Now.AddSeconds(5));
        }
    }
}
