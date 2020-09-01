using System;

namespace C5_WithAgeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            //  person.AskForName();
            // person.AskForAge();
            // person.NameContains();
            //person.AskForCity();
            person.AskForDateOfBirth();

            Console.ReadKey();
        }
    }
}
