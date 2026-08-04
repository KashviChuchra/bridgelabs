using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person2(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public virtual void DisplayRole()
        {
            Console.WriteLine($"Role of {Name}, aged {Age} is ");
        }
    }
    internal class Teacher : Person2
    {
        public string Subject { get; set; }
        public Teacher(string n, int a, string s) : base(n, a)
        {
            Subject = s;
        }
        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Teacher of {Subject}");
        }
    }
    internal class Student : Person2
    {
        public char Grade { get; set; }
        public Student(string n, int a, char g) : base(n, a)
        {
            Grade = g;
        }
        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Student with grade {Grade}");
        }
    }
    internal class Staff : Person2
    {
        public string Department { get; set; }
        public Staff(string n, int a, string d) : base(n, a)
        {
            Department = d;
        }
        public override void DisplayRole()
        {
            base.DisplayRole();
            Console.WriteLine($"Staff member of {Department} department");
        }
    }
}
