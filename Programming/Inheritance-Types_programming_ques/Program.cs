using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a=new Animal();
            //a.MakeSound();


            //Book book= new Book();
            //book.DisplayDetails();
            //book.Title = "RD Sharma";
            //book.PublicationYear = 2020;
            //book.DisplayDetails();
            //Author author= new Author();
            //author.DisplayDetails();
            //author.Name = "Ravi";
            //author.Bio = "Author of Maths Book";
            //author.Title = "Maths Fundamentals";
            //author.PublicationYear = 1998;
            //author.DisplayDetails();


            //Device device1 = new Device(101,"running");
            //device1.DisplayStatus();
            //Device device2=new Thermostat(102, "off", 25.5);
            //device2.DisplayStatus();
            //Device device3 = new Device(101,"error");
            //device3.DisplayStatus();


            //Order order1 = new Order(1, DateTime.Now);
            //order1.OrderStatus();
            //Order order2 = new ShippedOrder(2, DateTime.Now, 1000132);
            //order2.OrderStatus();
            //Order order3 = new DelieveredOrder(3, DateTime.Now, 1000133, DateTime.Now);
            //order3.OrderStatus();


            //OnlineCourse course= new PaidOnlineCourse();
            //course.CourseName = "C# Programming";
            //course.Duration = 30;
            //course.Platform = "Udemy";
            //course.IsRecorded = true;
            //course.DisplayOnlineCourse();


            //BankAccount bank = new BankAccount(1001, 50000);
            //bank.DisplayAccountType();
            //bank.Deposit(10000);
            //bank.DisplayAccountType();
            //bank.Withdraw(5000);
            //bank.DisplayAccountType();
            SavingsAccount savings = new SavingsAccount(1002, 20000, 0.05);
            savings.DisplayAccountType();




            //Person2 person = new Person2("John", 30);
            //person.DisplayRole();
            //Teacher teacher = new Teacher("Alice", 35, "Mathematics");
            //teacher.DisplayRole();
            //Person2 person1 = new Teacher("Bob", 40, "Physics");
            //person1.DisplayRole();


            //Chef p1 = new Chef("Kashvi", 101);
            //p1.PerformDuties();
            //p1.Info();
            //Waiter p2 = new Waiter("Alice", 102);
            //p2.PerformDuties();
            //p2.Info();


            //Vehicle v1 = new Vehicle(95, "Toyota");
            //v1.DisplayVehicle();
            //ElectricVehicle ev1 = new ElectricVehicle(150, "Tesla");
            //ev1.DisplayElectricVehicle();
            //PetrolVehicle pv1 = new PetrolVehicle(120, "Honda");
            //pv1.DisplayPetrolVehicle();
            //pv1.Refuel();


        }
    }
}