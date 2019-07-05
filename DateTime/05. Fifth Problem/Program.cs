using System;

namespace _05._Fifth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Write a program to get current time in milliseconds.
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Time in miliseconds is: " + (DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond));
            
            double totalMilli = (new TimeSpan(DateTime.Now.Ticks)).TotalMilliseconds;
            Console.WriteLine(totalMilli);
           
        }
    }
}
