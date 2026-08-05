using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }
    abstract internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int productId, string name, int price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }
        public abstract double CalculateDiscount();
        public void DisplayDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Product Id:\t{ProductId}");
            Console.WriteLine($"Product Name:\t{Name}");
            Console.WriteLine($"Product Price: {Price}");
        }

    }
    internal class Electronics : Product, ITaxable
    {
        private double Discount { get; set; }
        private readonly double tax = 18;

        public Electronics(int productId, string name, int price, int discount) : base(productId, name, price)
        {
            Discount = discount;
        }
        public override double CalculateDiscount()
        {
            return Price - Price * Discount / 100;
        }
        public double CalculateTax()
        {
            return CalculateDiscount() * tax / 100;

        }
        public void GetTaxDetails()
        {
            Console.WriteLine($"Amount to pay including tax:{CalculateDiscount()+CalculateTax()}");
        }

    }
    internal class Clothing : Product, ITaxable
    {
        private double Discount { get; set; }
        private readonly double tax = 20;

        public Clothing(int productId, string name, int price, int discount) : base(productId, name, price)
        {
            Discount = discount;
        }
        public override double CalculateDiscount()
        {
            return Price - Price * Discount / 100;
        }
        public double CalculateTax()
        {
            return CalculateDiscount() * tax / 100;

        }
        public void GetTaxDetails()
        {
            Console.WriteLine($"Amount to pay including tax:{CalculateDiscount() + CalculateTax()}");
        }
    }
    internal class Grocery : Product, ITaxable
    {
        private double Discount { get; set; }
        private readonly double tax = 10;

        public Grocery(int productId, string name, int price, int discount) : base(productId, name, price)
        {
            Discount = discount;
        }
        public override double CalculateDiscount()
        {
            return Price - Price * Discount / 100;
        }
        public double CalculateTax()
        {
            return CalculateDiscount() * tax / 100;

        }
        public void GetTaxDetails()
        {
            Console.WriteLine($"Amount to pay including tax:{CalculateDiscount() + CalculateTax()}");
        }
    }
}
