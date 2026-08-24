using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    internal class Rider
    {
        public int RiderId { get; set; }
        public string RiderName { get; set; } = "";

        public Rider(int id, string name)
        {
            RiderId = id;
            RiderName = name;
        }

    }
}
