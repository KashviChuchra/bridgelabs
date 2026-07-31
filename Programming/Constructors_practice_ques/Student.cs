using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    // University-Management-System
    class Student
    {
        public int RollNo;
        protected string Name;
        private double CGPA;

        public Student()
        {
            this.RollNo = 0;
            this.Name = string.Empty;
            this.CGPA = 0.0;
        }
        public Student(int roll, string n, double cgpa)
        {
            this.RollNo = roll;
            this.Name = n;
            this.CGPA = cgpa;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public void setCgpa(double CGPA)
        {
            this.CGPA = CGPA;
        }
        public double ModifyCGPA()
        {
            return CGPA;
        }
    }
    class PostgraduateStudent : Student
    {
        public void display()
        {
            Console.WriteLine("==================");
            Console.WriteLine(RollNo);
            Console.WriteLine(Name);
            Console.WriteLine(ModifyCGPA());

        }
    }
}
