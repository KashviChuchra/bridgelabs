using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }
    abstract internal class FoodItem
    {
        private string itemName;
        private int price;
        private int quantity;

        public string ItemName { get { return itemName; } set { if (value != null) itemName = value; else itemName = "Unknown"; } }
        public int Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }

        public FoodItem(string name, int price, int quantity)
        {
            ItemName = name;
            Price = price;
            Quantity = quantity;
        }
        public abstract double CalculateTotalPrice();
        public void GetItemDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");

        }

    }
    internal class VegItem : FoodItem, IDiscountable
    {
        public double Discount { get; set; }
        public VegItem(string name, int price, int quantity, double discount) : base(name, price, quantity)
        {
            Discount= discount;
        }

        
        public override double CalculateTotalPrice()
        {
            return (Quantity * Price)-ApplyDiscount();
        }
        public double ApplyDiscount()
        {
            return Price * Quantity * 0.01 * Discount;
        }
        public void GetDiscountDetails()
        {
            Console.WriteLine($"Total Amount to pay before Discount: {Price*Quantity}");
            Console.WriteLine($"Total Amount to pay after Discount: {CalculateTotalPrice()}");
        }

    }
    internal class NonVegItem : FoodItem, IDiscountable
    {
        public double Discount { get; set; }
        public NonVegItem(string name, int price, int quantity, double discount) : base(name, price, quantity)
        {
            Discount = discount;
        }


        public override double CalculateTotalPrice()
        {
            return (Quantity * Price) - ApplyDiscount();
        }
        public double ApplyDiscount()
        {
            return Price * Quantity * 0.01 * Discount;
        }
        public void GetDiscountDetails()
        {
            Console.WriteLine($"Total Amount to pay before Discount: {Price * Quantity}");
            Console.WriteLine($"Total Amount to pay after Discount: {CalculateTotalPrice()}");
        }
    }
}
