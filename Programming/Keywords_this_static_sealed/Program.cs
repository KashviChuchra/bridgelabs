using System;

namespace keywods_this_static_sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount b1 = new BankAccount("Kashvi", 101);
            //BankAccount b2 = new BankAccount("Hargun", 102);
            //b1.details();
            //b2.details();

            //BankAccount.GetTotalAccounts();
            //Console.WriteLine();

            //object obj = b1;

            //if (obj is BankAccount account)
            //{
            //    Console.WriteLine("Object is a BankAccount.");
            //    account.details();
            //}
            //else
            //{
            //    Console.WriteLine("Not a BankAccount object.");
            //}

            //Book b1 = new Book("C# Programming", "Kashvi", 1001);

            //Book.DisplayLibraryName();

            //object obj = b1;

            //if (obj is Book book)
            //{
            //    Console.WriteLine("It is a Book object.");
            //    book.DisplayDetails();
            //}
            //else
            //{
            //    Console.WriteLine("Not a Book object.");
            //}

            //Employee e1 = new Employee("Kashvi", 101, "Software Engineer");

            //object obj = e1;

            //if (obj is Employee emp)
            //{
            //    Console.WriteLine("Object is an Employee.");
            //    emp.DisplayDetails();
            //}

            //Employee.DisplayTotalEmployees();


            //Product.UpdateDiscount(10);

            //Product p1 = new Product(101, "Laptop", 55000, 2);

            //object obj = p1;

            //if (obj is Product product)
            //{
            //    product.DisplayDetails();
            //}

            //Student s1 = new Student("Kashvi", 101, "A");

            //object obj = s1;

            //if (obj is Student student)
            //{
            //    student.DisplayDetails();
            //}

            //Student.DisplayTotalStudents();

            //Vehicle.UpdateRegistrationFee(6500);

            //Vehicle v1 = new Vehicle("Rahul", "Car", 12345);

            //object obj = v1;

            //if (obj is Vehicle vehicle)
            //{
            //    vehicle.DisplayDetails();
            //}

            Patient p1 = new Patient("Aman", 25, "Fever", 1001);

            object obj = p1;

            if (obj is Patient patient)
            {
                patient.DisplayDetails();
            }

            Patient.GetTotalPatients();
        }
    }
}