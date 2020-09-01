using System;

namespace C3_WithAClass
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("Welcome dude! What's your name? ");
            person.Name = Console.ReadLine();

            Console.Write($"{person.Name} sweet :) How old are you man? ");

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
                //age= int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");
                person.Age = Convert.ToInt32(Console.ReadLine());

            }
            finally
            {
                Console.Write($"Cool man! We are the same age, i'm also {person.Age}.");
            }

            Console.WriteLine($"\nDude your name contains {person.Name.Length} characters.");
            Console.Write($"{person.Name} where do you live? ");
            person.City = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother also lives in {person.City}");



            Console.ReadKey();

        }
    }
}
