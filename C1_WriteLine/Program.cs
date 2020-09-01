using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Jesper\Documents\documents.txt";
            var path2 = "C:\\Users\\Jesper\\Documents\\documents.txt";


            string name = "Jesper";
            int age = 25;
            var city = "Köping";
            
            

            var text1 = "Welcome Jesper. You are 25 years old right? Jesper do you live in Köping?";
            var text2 = "Welcome " + name + ". You are " + age + " years old right? " + name + " do you live in " + city + "?";
            var text3 = String.Format("Welcome {0}. You are {1} years old right? {0} do you live in {2}?", name, age, city);
            var text4 = $"Welcome {name}. You are {age} years old right? {name} do you live in {city}?";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);

            Console.ReadKey();
           

        }
    }
}
