using System;

namespace keywods_this_static_sealed
{
    internal class Vehicle
    {
        public static double RegistrationFee = 5000;

        public string ownerName;
        public string vehicleType;
        public readonly int registrationNumber;

        public Vehicle(string ownerName, string vehicleType, int registrationNumber)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
            this.registrationNumber = registrationNumber;
        }

        public static void UpdateRegistrationFee(double fee)
        {
            RegistrationFee = fee;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Owner Name : {ownerName}");
            Console.WriteLine($"Vehicle Type : {vehicleType}");
            Console.WriteLine($"Registration Number : {registrationNumber}");
            Console.WriteLine($"Registration Fee : {RegistrationFee}");
        }
    }
}