using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class Rider
    {
        public int RiderId { get; set; }
        public string Name { get; set; } = "";

        public Rider() { }
        public Rider(int id, string name)
        {
            RiderId = id;
            Name = name;
        }

    }
}
