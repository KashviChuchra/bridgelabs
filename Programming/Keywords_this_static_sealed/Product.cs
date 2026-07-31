using System;
using System.Collections.Generic;
using System.Text;

namespace keywods_this_static_sealed
{
    internal class Product
    {
        public static double discount;
        public string productName;
        public double price;
        public int quantity;
        public readonly int product_id;
        public static void UpdateDiscount(double d)
        {
            discount = d;
        }
        public Product(int product_id,string name,double price, int quant)
        {
            this.product_id= product_id;
            this.productName = name;
            this.price = price;
            this.quantity = quant;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Product ID : {product_id}");
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Price : {price}");
            Console.WriteLine($"Quantity : {quantity}");
            Console.WriteLine($"Discount : {discount}%");
        }

    }
}
