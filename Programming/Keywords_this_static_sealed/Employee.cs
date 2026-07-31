using System;
using System.Collections.Generic;
using System.Text;

namespace keywods_this_static_sealed
{
    internal class Employee
    {
        public static string CompanyName="Google";
        public static int totalEmployee;
        public string name;
        public readonly int id;
        public string designation;

        public Employee()
        {
            totalEmployee++;
        }

        public Employee(string name, int id, string designation)
        {
            this.name = name;
            this.id = id;
            this.designation = designation;
            totalEmployee++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployee}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Company Name : {CompanyName}");
            Console.WriteLine($"Employee ID : {id}");
            Console.WriteLine($"Employee Name : {name}");
            Console.WriteLine($"Designation : {designation}");
        }

    }
}
