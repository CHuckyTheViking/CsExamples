using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public void AskForName()
        {
            Console.Write("Welcome dude! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name}, sweet :) ");
        }

        public void AskForAge()
        {
            Console.Write("How old are you man? ");

            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
                //age= int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");
                Age = Convert.ToInt32(Console.ReadLine());

            }
            finally
            {
                Console.Write($"Cool man! We are the same age, i'm also {Age}.");
            }

        }

        public void NameContains()
        {
            Console.WriteLine($"\nDude your name contains {Name.Length} characters.");
        }

        public void AskForCity()
        {
            
            Console.Write($"{Name} where do you live? ");
            City = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother also lives in {City}");

        }

    }
}
