using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class Order
    {
        public int OrderId { get; set; }
        public int RestaurantId { get; set; }
        public int RiderId { get; set; }
        public string Status { get; set; } = "Pending";
        public double Amount { get; set; }
        
    }
}
