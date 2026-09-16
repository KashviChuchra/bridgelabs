using System;
using System.Collections.Generic;
using System.Text;

namespace IO_Programming.CSV_Handling
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
