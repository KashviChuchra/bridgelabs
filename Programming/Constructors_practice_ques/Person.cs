using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Guest";
            Age = 0;

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(Person anotherPerson)
        {
            Name = anotherPerson.Name;
            Age = anotherPerson.Age;
        }

        public void display()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
