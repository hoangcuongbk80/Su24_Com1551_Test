// Do not change this file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su24_Test
{
    public class Person
    {
        public string FullName { get; set; }
        public string Phone { get; set; }

        // Default constructor
        public Person() { }

        // Constructor with parameters
        public Person(string fullName, string phone)
        {
            FullName = fullName;
            Phone = phone;
        }
    }
}
