using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WPF1_ContactList.Models
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname => $"{FirstName} {LastName}";

        public Contact(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

    }
}
