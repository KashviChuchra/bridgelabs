using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace FoodDelivery
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set;}
        public double Distance { get; set; }
        public List<MenuItem> Menu { get; set; } 

        public Restaurant() { }
        public Restaurant(int restaurantID, string restaurantName, double rating, int distance)
        {
            RestaurantID = restaurantID;
            Name = restaurantName;
            Rating = rating;
            Menu = new List<MenuItem>();
        }
        public void Display()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Restaurant ID: {RestaurantID}");
            Console.WriteLine($"Restaurant Name: {Name}");
            Console.WriteLine($"Restaurant Rating: {Rating}");
            Console.WriteLine($"Restaurant Distance: {Distance}");

        }

        public void AddFoodItemInMenu(int itemId,string itemName, int quantity, double price)
        {
            Menu.Add(new MenuItem(itemId, itemName, quantity, price));
        }
        public void RemoveFoodItemFromMenu(int itemId)
        {
            MenuItem item = Menu.Find(m => m.ItemId == itemId);
            if(item == null)    throw new KeyNotFoundException("Menu item not found");
            Menu.Remove(item);
        }
        public List<MenuItem> RetriveMenu()
        {
            return Menu;
        }
       
    }
}
