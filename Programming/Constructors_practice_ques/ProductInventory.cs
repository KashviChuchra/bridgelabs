using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class ProductInventory
    {
        public string ProductName { get; set; }
        public int Price { get; set; }

        public static int TotalProducts { get; set; }
        public void DisplayProductDetails()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");

        }
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"No of products created: {TotalProducts}");
        }

    }
}
