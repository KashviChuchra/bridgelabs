using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class CoffeeShopOrder
    {
        private string customerName;
        public string coffeeType;
        public int quantity;
        public double price;

        public string CustomerName { get; set; }
        public string CoffeeType { get; set; }
        public int Quantity { get; set; }
        public double Price { get; private set; }

        public CoffeeShopOrder()
        {
            CustomerName = "Guest";
            CoffeeType = "Regular";
            Quantity = 1;
            Price = calculatePrice();
        }

        public CoffeeShopOrder(string customerName, string coffeeType, int quantity)
        {
            CustomerName = customerName;
            CoffeeType = coffeeType;
            Quantity = quantity;
            Price = calculatePrice();
        }

        public CoffeeShopOrder(CoffeeShopOrder previousOrder)
        {
            CustomerName = previousOrder.CustomerName;
            CoffeeType = previousOrder.CoffeeType;
            Quantity = previousOrder.Quantity;
            Price = previousOrder.Price;
        }

        private double calculatePrice()
        {
            double pricePerCup()
            {
                double price = 0.0;
                string coffee_type = CoffeeType.ToLower();
                switch (coffee_type)
                {
                    case "latte":
                        price = 200;
                        break;
                    case "espresso":
                        price = 300;
                        break;
                    case "mocha":
                        price = 250;
                        break;
                    default:
                        price = 100;
                        break;

                }
                return price;
            }
            return pricePerCup() * Quantity;
        }
        public void displayOrderDetails()
        {
            Console.WriteLine($"Customer Name: {CustomerName}\nCoffeeType:{CoffeeType}\nQuantity:{Quantity}\nPrice:{Price}");
        }
    }
}
