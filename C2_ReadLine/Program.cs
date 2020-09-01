using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age = 0;

            Console.Write("Welcome dude! What's your name? ");
            name = Console.ReadLine();

            Console.Write($"{name} sweet :) How old are you man? ");
           
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                //age= int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sorry dude! your age must be in digits. Try again man.");
                Console.Write("How old are you man? ");
                age = Convert.ToInt32(Console.ReadLine());

            }
            finally
            {
                Console.Write($"Cool man! We are the same age, i'm also {age}.");
            }

            Console.WriteLine($"\nDude your name contains {name.Length} characters.");
            Console.Write($"{name} where do you live? ");
            var city = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother also lives in {city}");

            

            Console.ReadKey();

        }
    }
}
