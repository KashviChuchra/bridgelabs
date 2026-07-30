using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Objects_level1
{
    class EmployeeDetails
    {
        private string name;
        private int id;
        private long salary;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.All(char.IsLetter))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id > 0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Id can't be -ve 0r 0");
                }
            }
        }
        public long Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (salary > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary can't be 0 or -ve");
                }
            }
        }
        public EmployeeDetails()
        {
            this.name = "";
            this.id = 0;
            this.salary = 0;
        }
        public EmployeeDetails(string name, int id, long salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine($"Name:\t{name}\nId:\t{id}\nSalary:\t{salary}");
        }

    }
}
