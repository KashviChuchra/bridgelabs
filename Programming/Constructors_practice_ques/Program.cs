using class_objects2;
using System;
namespace class_objects_practice;

class Program
{

    //class BankAccount
    //{
    //    public int accountNumber;
    //    protected string accountHolder;
    //    private int balance;

    //    public int Balance { get; set; }
    //    public void setAccountHolder(string accountHolder)
    //    {
    //        this.accountHolder= accountHolder;
    //    }


    //}
    //class SavingsAccount: BankAccount
    //{
    //    public void details()
    //    {
    //        Console.WriteLine("=====================================");
    //        Console.WriteLine($"Account NUmber: {accountNumber}");
    //        Console.WriteLine($"Account Holder: {accountHolder}");
    //        Console.WriteLine($"Balance: {Balance}");
    //    }
    //}

    //class

    //class EmployeeRecords
    //{
    //    public int EmployeeID { get; set; }
    //    protected string Department { get; set; }
    //    private int Salary { get; set; }

    //    public void SetSalary(int salary)
    //    {
    //        Salary = salary;
    //    }

    //    public void SetDepartment(string department)
    //    {
    //        Department = department;
    //    }

    //}
    //class Manager:  EmployeeRecords
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine(EmployeeID);
    //        Console.WriteLine(Department);

    //    }

    //}
    public static void Main(string[] args)
    {

        //CoffeeShopOrder obj = new CoffeeShopOrder();
        //obj.displayOrderDetails();
        //CoffeeShopOrder obj1 = new CoffeeShopOrder("Kashvi", "espresso", 2);
        //obj1.displayOrderDetails();

        //Book book = new Book();
        //book.displayDetails();
        //book.BorrowBook();
        //Book book1 = new Book("Maths", "RD Sharma", 500);
        //book1.displayDetails();
        //book1.BorrowBook();
        //book1.Price = 400;
        //book1.displayDetails();
        //book1.BorrowBook();
        EBook  b=   new EBook();
        b.ISBN = 111;
        b.setTitleName("Maths");
        b.setAuthorName("RD SHarma");
        b.Price = 1000;
        b.display();

        //Circle c = new Circle();
        //c.area();
        //Circle c1 = new Circle(5);
        //c1.area();
        //c1.Radius = 10;
        //c1.area();


        //Person p1=new Person();
        //p1.display();
        //Person p2 = new Person("Kashvi",18);
        //p2.display();
        //p2.Age = 21;
        //p2.display();
        //Person p3= new Person(p1);
        //p3.display();


        //HotelBooking book=new HotelBooking();
        //book.display();
        //HotelBooking book1 = new HotelBooking("Kashvi", "two-seater",3);
        //book1.display();
        //book1.RoomType = "luxe";
        //book1.display();
        //HotelBooking book2 = new HotelBooking(book);
        //book2.display();


        //CarRental car=new CarRental();
        //car.display();
        //car.CalculateCost();
        //CarRental car1 = new CarRental("Kashvi","BMW",2);
        //car1.display();
        //car1.CalculateCost();
        //car1.RentalDays = 10;
        //car1.display();
        //car1.CalculateCost();


        //ProductInventory p=new ProductInventory();
        //p.DisplayProductDetails();
        //p.ProductName = "Car";
        //p.Price = 1000000;
        //ProductInventory.TotalProducts++;
        //p.DisplayProductDetails();
        //ProductInventory.DisplayTotalProducts();
        //ProductInventory p1 = new ProductInventory();
        //p1.ProductName = "Chair";
        //p1.Price = 1000;
        //ProductInventory.TotalProducts++;
        //p1.DisplayProductDetails();
        //ProductInventory.DisplayTotalProducts();

        //OnlineCourse c1=new OnlineCourse();
        //c1.Duration = 4;
        //c1.CourseName = "cse";
        //c1.Fee = 800000;
        //OnlineCourse.InstituteName="Chitkara University";
        //c1.DisplayCourseDetails();
        //c1.updateInstituteName("CU");
        //c1.DisplayCourseDetails();


        //Vehicle v1= new Vehicle();
        //v1.OwnerName = "Kashvi";
        //v1.VehicleName = "Jupiter";
        //Vehicle.RegisterationFee = 10000;
        //v1.DisplayVehicleDetails();
        //v1.updateRegistrationFee(12000);
        //v1.DisplayVehicleDetails();


        //PostgraduateStudent student = new PostgraduateStudent();
        //student.RollNo = 793;
        //student.setName("Kashvi");
        //student.setCgpa(9.35);
        //student.display();



        //Manager m = new Manager();

        //m.EmployeeID = 101;
        //m.SetDepartment("IT");
        //m.SetSalary(50000);

        //m.Display();


        //SavingsAccount acc = new SavingsAccount();

        //acc.accountNumber = 101;
        //acc.setAccountHolder("Kashvi");
        //acc.Balance = 10000;

        //acc.details();

    }
}