using System;
namespace Encapsulation_Polymorphism_Interface_AbstractClass;

class Program
{
    static void ProcessRide(Vehicle v, double distance)
    {
        v.GetVehicleDetails();
        Console.WriteLine($"Distance : {distance} km");
        Console.WriteLine($"Fare     : {v.CalculateFare(distance)}");
        if (v is IGPS gps)
        {
            Console.WriteLine($"Current Location : {gps.GetCurrentLocation()}");
            gps.UpdateLocation("Chitkara University");
        }



        Console.WriteLine();
    }




    //static void ProcessEmployment(Employee emp)
    //{
    //    emp.DisplayDetails();
    //    Console.WriteLine($"Salary: {emp.CalculateSalary()}");
    //    if (emp is IDepartment dept )
    //    {
    //        dept.AssignDepartment();
    //        dept.GetDepartmentDetails();
    //    }
    //}

    //static void ProcessProduct(Product p1)
    //{
    //    p1.DisplayDetails();
    //    Console.WriteLine($"Discounted Price: {p1.CalculateDiscount()}");
    //    if(p1 is ITaxable t)
    //    {
    //        t.CalculateTax();
    //        t.GetTaxDetails();
    //    }
    //}

    //static void ProcessVehicleRental(VehicleRental v1)
    //{
    //    v1.GetVehicleDetails();
    //    Console.WriteLine($"Rental Cost: {v1.CalculateRentalCost()}");

    //    if (v1 is IInsurable i)
    //    {
    //        Console.WriteLine($"Insurance Cost: {i.CalculateInsurance()}");
    //        i.GetInsuranceDetails();
    //    }
    //}

    //static void ProcessBanking(BankAccount account)
    //{
    //    account.DisplayDetails();

    //    if(account is ILoanable i)
    //    {
    //        i.ApplyForLoan();
    //        i.CalculateLoanEligibility();
    //    }
    //    //Console.WriteLine($"Interest on Savings Account: {account.CalculateIntererst()}");
    //    //Console.WriteLine($"Interest on Current Account: {account.CalculateIntererst()}");

    //}

    //static void ProcessLibraryBooks(LibraryItem item)
    //{
    //    item.GetItemDetails();
    //    item.GetLoanDuration();
    //    if(item is IReservable i)
    //    {

    //        i.CheckAvailability();
    //        i.ReserveItem();
    //    }
    //}

    static void ProcessFoodItem(FoodItem item)
    {
        item.GetItemDetails();
        if(item is IDiscountable i)
        {
            i.GetDiscountDetails();
        }
    }
    public static void Main(string[] args)
    {

        //Employee FullTimeEmp = new FullTimeEmployee(101, "Kashvi", 50000);
        //Employee PartTimeEmp = new PartTimeEmployeee(102, "Hargun", 100000);
        //ProcessEmployment(FullTimeEmp);
        //ProcessEmployment(PartTimeEmp);


        //Product e1 = new Electronics(101, "phone", 100000, 10);
        //Product c1 = new Clothing(102, "Dress", 2000, 10);
        //Product g1 = new Grocery(103, "Chips", 100, 2);
        //ProcessProduct(e1);
        //ProcessProduct(c1);
        //ProcessProduct(g1);


        //VehicleRental car = new Car(101,"Car",1000,3);
        //VehicleRental bike = new Bike(221, "Bike", 550, 4);
        //VehicleRental truck = new Truck(102, "Truck", 2000, 3);
        //ProcessVehicleRental(car);
        //ProcessVehicleRental(bike);
        //ProcessVehicleRental(truck);


        //BankAccount sa=new SavingsAccount(111,"Kashvi",50000);
        //BankAccount ca = new CurrentAccount(111, "Kashvi", 20000);
        //BankAccount sa1 = new SavingsAccount(112, "Hargun", 70000);
        //BankAccount ca1 = new CurrentAccount(112, "Hargun", 10000);
        //ProcessBanking(sa);
        //ProcessBanking(ca);
        //ProcessBanking(sa1);
        //ProcessBanking(ca1);


        //LibraryItem book = new Book(101,"Maths","RD Sharma");
        //LibraryItem book1 = new Book(290, "English Novel", "Chetan Bhagat");
        //LibraryItem magazine = new Magazine(302, "Vogue", "Enna");
        //LibraryItem dvd = new DVD(126, "Annual Function", "elle");
        //ProcessLibraryBooks(book);
        //ProcessLibraryBooks(magazine);
        //ProcessLibraryBooks(dvd);
        //ProcessLibraryBooks(book1);
        //ProcessLibraryBooks(dvd);


        //FoodItem veg = new VegItem("French Fries", 120, 1, 10);
        //FoodItem nonveg = new NonVegItem("Chicken French Fries", 180, 1, 10);
        //ProcessFoodItem(veg);
        //ProcessFoodItem(nonveg);



        //IMedicalRecord patient1 = new InPatient(101, "John", 30);
        //IMedicalRecord patient2 = new OutPatient(201, "Alice", 25);
        //patient1.ViewRecord();
        //Console.WriteLine();
        //patient2.ViewRecord();
        //Console.WriteLine();
        //patient1.AddRecord(102, "David", 40);
        //patient2.AddRecord(202, "Emma", 28);
        //Console.WriteLine("After Updating Records:\n");
        //patient1.ViewRecord();
        //Console.WriteLine();
        //patient2.ViewRecord();



        Vehicle car1 = new Car(101, "Aman", 100);
        Vehicle bike1 = new Bike(102, "Bhumi", 70);
        Vehicle auto1 = new Auto(103, "Dheeraj", 75);
        ProcessRide(car1, 10);
        ProcessRide(bike1, 10);
        ProcessRide(auto1, 10);




    }
}