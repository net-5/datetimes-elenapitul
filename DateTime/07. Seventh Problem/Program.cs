using System;

namespace _07._Seventh_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Write a program to get the first and last second of a day.
            DateTime now = DateTime.Now;
            DateTime firstSec = DateTime.Now.Date;
            Console.WriteLine(firstSec);
            DateTime lastSec = DateTime.Now.Date.AddDays(1).AddTicks(-1);
            Console.WriteLine(lastSec);
        }
    }
}
