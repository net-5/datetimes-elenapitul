using System;
using Third_Problem;

namespace _09._Ninth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Given a date of birth, calculate the age of a person.
            //Input: 10, 09, 1989
            //Output: 29

            RandomDateTime randDay = new RandomDateTime();
            DateTime dateBirth = randDay.Next();
            int age = DateTime.Now.Year - dateBirth.Year;

            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine(dateBirth.Year);

            Console.WriteLine("Date of birth is " + dateBirth.ToString("MMMM, dd, yyyy"));
            Console.WriteLine("Age is " + age);
        }
    }
}
