using System;
using System.Globalization;
using System.Linq;

namespace Second_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a program to add N year(s) to the current date and display the new date.
            Console.WriteLine("How many years do you want to add to the current date?");
            bool valid = false;
            var N = 0;
            while (valid == false)
            {
                string Input = Console.ReadLine();
                if(int.TryParse(Input, out N))
                {
                    valid = true;
                }

                else
                {
                    Console.WriteLine("Not a number, please try again.");
                }
            }
                        
            Console.WriteLine("New date is: " + DateTime.Now.AddYears(N).ToString("dddd, MMM dd yyy, hh:mm:ss"));
        }
    }
}
