using System;

namespace Third_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Write a program to display the date and time in a human-friendly string.
            RandomDateTime date = new RandomDateTime();
            //Console.WriteLine(date.Next());
            Console.WriteLine("Human-friendly date: " + date.Next().ToString("U"));
        }
    }
}
