﻿using C14_Abstract_1.Models;
using System;
using System.Collections.Generic;

namespace C14_Abstract_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classlist = new List<Person>()
            {
                new Teacher { FirstName = "Hans", LastName = "Andersson", Role = "Teacher" },
                new Student { FirstName = "Jesper", LastName = "Müllern" },
                new Student { FirstName = "Kalle", LastName = "Larsson" }

            };

            
            

            foreach (var person in classlist)
            {
                if(person is Teacher teacher)
                    Console.WriteLine($"{teacher.FirstName} {teacher.LastName} - {teacher.Role}");
                else
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
            

            
        }
    }
}
