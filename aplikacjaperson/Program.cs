using aplikacjaperson;
using System;

namespace aplikacjaperson
{
    class Program
    {
        static void Main(string[] args)
        {
            person1 person = new person1();

            Console.WriteLine("Date of birth: " + person.BirthDate);
            Console.WriteLine("Gender: " + person.GetGender);

            Console.ReadLine();
        }
    }
}