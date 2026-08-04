using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Device
    {
        public int DeviceId { get; set; }
        public string Status { get; set; }

        public Device(int id, string s)
        {
            DeviceId = id;
            Status = s;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
        }

    }
    internal class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }
        public Thermostat(int id, string s, double temp) : base(id, s)
        {
            TemperatureSetting = temp;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Showing Settings: {TemperatureSetting}..");
        }
    }
}
