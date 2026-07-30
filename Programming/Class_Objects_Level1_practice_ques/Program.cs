using System;
using System.Runtime.Intrinsics.X86;
namespace Class_Objects_level1;

class Program
{

    public static void Main(string[] args)
    {
        EmployeeDetails emp = new EmployeeDetails("Hargun", 778, 40000);
        emp.display();
        emp.Name = "Kashvi";
        emp.Id = 793;
        emp.Salary = 35000;
        emp.display();


        AreaOfCircle a = new AreaOfCircle(1);
        double area = a.calculateArea();
        a.displayArea(area);
        a.Radius = 2;
        area = a.calculateArea();
        a.displayArea(area);


        BookDetails book = new BookDetails("book1", "author1",1000);
        book.display();
        book.Title = "book2";
        book.Author = "author2";
        book.Price = 200;
        book.display();


    }
}