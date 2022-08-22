using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, string city, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Age = age;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string City { get; }
        public int Age { get; }
    }
}
