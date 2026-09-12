using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; } 
        public double Price { get; set; }
        public int Quantity { get; set; }

        public MenuItem() { }
        public MenuItem(int ItemId, string ItemName, int Quantity, double Price)
        {
            this.ItemId = ItemId;
            this.Name = ItemName;
            this.Price = Price;
            this.Quantity = Quantity;

        }
      

    }
}
