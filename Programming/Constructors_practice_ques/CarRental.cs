using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class CarRental
    {
        public string CustomerName { get; set; }
        public string CarModel { get; set; }
        public int RentalDays { get; set; }
        public double Cost { get; private set; }

        public CarRental()
        {
            CustomerName = "Guest";
            CarModel = "ABC";
            RentalDays = 1;
            Cost = CalculateCost();
        }

        public CarRental(string name, string model, int days)
        {
            CustomerName = name;
            CarModel = model;
            RentalDays = days;
            Cost = CalculateCost();
        }

        public double CalculateCost()
        {
            double pricePerDay = 100;
            return pricePerDay * RentalDays;
        }
        public void display()
        {
            Console.WriteLine("==============================================================================");
            Console.WriteLine($"Customer Name: {CustomerName} Car Model: {CarModel} Rental Days: {RentalDays}");
            Console.WriteLine($"Price: {Cost} ");
        }
    }
}
