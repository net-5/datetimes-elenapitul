using System;

namespace _06._Sixth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Write a program that calculates the date six months from the current date.
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddMonths(6));
        }
    }
}
