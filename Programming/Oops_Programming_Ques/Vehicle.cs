using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string location);
    }
    abstract internal class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId
        {
            get
            {
                return vehicleId;
            }
            set
            {
                vehicleId = value;
            }
        }
        public string DriverName
        {
            get
            {
                return driverName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    driverName = value;
                }
                else
                {
                    driverName = "Unknown";
                }
            }
        }
        public double RatePerKm
        {
            get
            {
                return ratePerKm;
            }
            set
            {
                if (value > 0)
                {
                    ratePerKm = value;
                }
                else
                {
                    ratePerKm = 1;
                }
            }
        }

        public Vehicle(int vehicleId, string driverName, double ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }
        public abstract double CalculateFare(double distance);
        public void GetVehicleDetails()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Vehicle Id: {VehicleId}");
            Console.WriteLine($"Driver Name: {DriverName}");
            Console.WriteLine($"Rate per Km: {RatePerKm}");
        }

    }
    internal class Car : Vehicle, IGPS
    {
        private string currentLocation = "Sector 17";

        public Car(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {

        }
        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance;
        }
        public string GetCurrentLocation()
        {
            return currentLocation;
        }
        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Location Updated : {currentLocation} -> {location}");
            currentLocation = location;
        }

    }
    internal class Bike : Vehicle, IGPS
    {
        private string currentLocation = "Bus Stand";

        public Bike(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {

        }
        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance * 0.90;
        }
        public string GetCurrentLocation()
        {
            return currentLocation;
        }
        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Location Updated : {currentLocation} -> {location}");
            currentLocation = location;
        }

    }
    internal class Auto : Vehicle, IGPS
    {
        private string currentLocation = "Sector 43 Market";

        public Auto(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {

        }
        public override double CalculateFare(double distance)
        {
            return 20 + RatePerKm * distance * 0.80;
        }
        public string GetCurrentLocation()
        {
            return currentLocation;
        }
        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Location Updated : {currentLocation} -> {location}");
            currentLocation = location;
        }
    }

}
