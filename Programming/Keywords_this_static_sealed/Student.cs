using System;

namespace keywods_this_static_sealed
{
    internal class Student
    {
        public static string UniversityName = "Chitkara University";
        public static int totalStudents;

        public string name;
        public readonly int rollNumber;
        public string grade;

        public Student(string name, int rollNumber, string grade)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.grade = grade;
            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students: {totalStudents}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"University : {UniversityName}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Roll Number : {rollNumber}");
            Console.WriteLine($"Grade : {grade}");
        }
    }
}