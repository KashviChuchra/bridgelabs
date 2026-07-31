using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    internal class Vehicle
    {
        public string OwnerName { get; set; }
        public string VehicleName { get; set; }
        public static int RegisterationFee { get; set; }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine($"Owner Name: {OwnerName} Vehicle Name: {VehicleName} RegisterationFee: {RegisterationFee}");

        }
        public void updateRegistrationFee(int fee)
        {
            RegisterationFee = fee;
        }

    }
}
