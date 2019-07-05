using System;

namespace _10._Tenth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //10. Write a program to get the dates 30 days before and 
            //after from the current date, and display it to the console.
            Console.WriteLine("Today is: " + DateTime.Now);
            Console.WriteLine("30 days ago was: " + DateTime.Now.AddDays(-30));
            Console.WriteLine("30 days from now will be: " + DateTime.Now.AddDays(30));
           

        }
    }
}
