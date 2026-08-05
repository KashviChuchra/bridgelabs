//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Encapsulation_Polymorphism_Interface_AbstractClass
//{
//    interface IInsurable
//    {
//        double CalculateInsurance();
//        void GetInsuranceDetails();
//    }
//    abstract internal class VehicleRental
//    {
//        public int VehicleNumber { get; set; }
//        public string Type { get; set; }
//        public double RentalRate { get; set; }

//        public VehicleRental(int vn, string type, double rate)
//        {
//            VehicleNumber = vn;
//            Type= type;
//            RentalRate = rate;
//        }
//        public abstract double CalculateRentalCost();
//        public void GetVehicleDetails()
//        {
//            Console.WriteLine("==============================");
//            Console.WriteLine($"Vehicle Number: {VehicleNumber}");
//            Console.WriteLine($"Vehicle Type: {Type}");
//            Console.WriteLine($"Rental Rate: {RentalRate}");
//        }

//    }
//    internal class Car : VehicleRental, IInsurable 
//    {
//        public int Days { get; set; }
//        public Car(int vn, string type, double rate, int days) : base(vn, type, rate)
//        {
//            Days = days;
//        }
//        public override double CalculateRentalCost()
//        {
//            return RentalRate * Days + 50;
//        }
//        public double CalculateInsurance()
//        {
//            return CalculateRentalCost() * 0.50;

//        }
//        public void GetInsuranceDetails()
//        {
//            Console.WriteLine($"Insurance Details: {CalculateInsurance()}");
//        }

//    }
//    internal class Bike : VehicleRental, IInsurable
//    {
//        public int Days { get; set; }
//        public Bike(int vn, string type, double rate, int days) : base(vn, type, rate)
//        {
//            Days = days;
//        }
//        public override double CalculateRentalCost()
//        {
//            return RentalRate * Days + 50;
//        }
//        public double CalculateInsurance()
//        {
//            return CalculateRentalCost() * 0.50;

//        }
//        public void GetInsuranceDetails()
//        {
//            Console.WriteLine($"Insurance Details: {CalculateInsurance()}");
//        }

//    }
//    internal class Truck : VehicleRental, IInsurable
//    {
//        public int Days { get; set; }
//        public Truck(int vn, string type, double rate, int days) : base(vn, type, rate)
//        {
//            Days = days;
//        }
//        public override double CalculateRentalCost()
//        {
//            return RentalRate * Days + 50;
//        }
//        public double CalculateInsurance()
//        {
//            return CalculateRentalCost() * 0.50;

//        }
//        public void GetInsuranceDetails()
//        {
//            Console.WriteLine($"Insurance Details: {CalculateInsurance()}");
//        }

//    }
//}
