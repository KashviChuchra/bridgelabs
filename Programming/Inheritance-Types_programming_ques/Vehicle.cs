using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    interface IRefuelable
    {
        void Refuel();
    }
    internal class Vehicle
    {
        public double MaxSpeed { get; set; }
        public string Model { get; set; }
        public Vehicle(double maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }
        public void DisplayVehicle()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Vehicle Model: {Model}");
            Console.WriteLine($"Vehicle Max Speed: {MaxSpeed} km/h"); 
        }
    }
    internal class ElectricVehicle : Vehicle
    {
        public ElectricVehicle(double maxSpeed, string model) : base(maxSpeed, model)
        {

        }
        public void Charge()
        {
            Console.WriteLine("Electric vehicle charged.");
        }
        public void DisplayElectricVehicle()
        {
            base.DisplayVehicle();
            Console.WriteLine("This is Electric Vehicle");
        }
    }
    internal class PetrolVehicle : Vehicle, IRefuelable
    {
        public PetrolVehicle(double maxSpeed, string model) : base(maxSpeed, model)
        {

        }
        public void Refuel()
        {
            Console.WriteLine("Petrol vehicle refueled.");
        }
        public void DisplayPetrolVehicle()
        {
            base.DisplayVehicle();
            Console.WriteLine("This is Petrol Vehicle");

        }
    }
    
}
