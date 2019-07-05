using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Ninth_Problem_Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Given a date of birth, calculate the age of a person.
            //Input: 10, 09, 1989
            //Output: 29
                     
            Console.WriteLine("Please enter your date of birth.");

            Console.WriteLine("Year: ");
            int inputYear = int.Parse(Console.ReadLine());
            while ((inputYear < DateTime.Now.Year - 110) || (inputYear > DateTime.Now.Year))
            {
                Console.WriteLine("Try again");
                inputYear = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Month: ");
            int inputMonth = int.Parse(Console.ReadLine());
            while ((inputMonth < 1) || (inputMonth > 12))
            {
                Console.WriteLine("Try again");
                inputMonth = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Day: ");
            var inputDay = int.Parse(Console.ReadLine());
            while ((inputDay < 1) || (inputDay > 31))
            {
                Console.WriteLine("Try again");
                inputDay = int.Parse(Console.ReadLine());
            }

            DateTime birth = new DateTime (inputYear, inputMonth, inputDay);
            int age = DateTime.Now.Year - birth.Year;
            Console.WriteLine("The age is " + age);          

        }

        

    }
}
