using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface IDepartment
    {
        string AssignDepartment();
        void GetDepartmentDetails();
    }
    abstract internal class Employee
    {
        private int employeeId;
        private string employeeName;
        private int baseSalary;

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                {
                    baseSalary = value;
                }
                else
                {
                    Console.WriteLine("Salary Can't be negative");
                    baseSalary = 0;
                }
            }
        }

        public Employee(int employee_id, string employeeName, int baseSalary)
        {
            EmployeeId = employee_id;
            EmployeeName = employeeName;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine("======================================");
            Console.WriteLine($"Employee Id: {EmployeeId}");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Base Salary: {BaseSalary}");
        }

    }

    internal class FullTimeEmployee : Employee, IDepartment
    {
        
        private int workingHours=10;
        private double fixedSalary = 10000;
        public FullTimeEmployee(int employee_id, string employeeName, int baseSalary) : base(employee_id, employeeName, baseSalary)
        {
        }
        public override double CalculateSalary()
        {
            return workingHours * 1000+fixedSalary+BaseSalary;
        }
        public string AssignDepartment()
        {
            return "IT";
        }
        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department: {AssignDepartment()}");
        }
    }
    internal class PartTimeEmployeee : Employee, IDepartment
    {
        private int workingHours = 5;
        private double fixedSalary = 9000;
        public PartTimeEmployeee(int employee_id, string employeeName, int baseSalary) : base(employee_id, employeeName, baseSalary)
        {
        }
        public override double CalculateSalary()
        {
            return workingHours * 1000 + fixedSalary + BaseSalary;
        }
        public string AssignDepartment()
        {
            return "Sales";
        }
        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department: {AssignDepartment()}");
        }

    }
}
