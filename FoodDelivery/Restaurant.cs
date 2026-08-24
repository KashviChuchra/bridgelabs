using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace FoodDelivery
{
    internal class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public Double Rating { get; set;}
        public Double Distance { get; set; }
        public List<MenuItem> menu = new();
        Dictionary<int, List<MenuItem>> getRatingByRestaurantId = new Dictionary<int, List<MenuItem>>();

        public Restaurant(int restaurantID, string restaurantName, double rating)
        {
            RestaurantID = restaurantID;
            Name = restaurantName;
            Rating = rating;
            menu = new List<MenuItem>();
        }
        public void Display()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Restaurant ID: {RestaurantID}");
            Console.WriteLine($"Restaurant Name: {Name}");
            Console.WriteLine($"Restaurant Rating: {Rating}");
        }

        public void AddFoodItemInMenu(int itemId,string itemName, int quantity, double price)
        {
            menu.Add(new MenuItem(itemId, itemName, quantity, price));
        }
        public void RemoveFoodItemFromMenu(int itemId)
        {
            menu.Remove();
        }
        public List<MenuItem> RetriveMenu(int id)
        {
            if (!getRatingByRestaurantId.ContainsKey(id))
            {
                Console.WriteLine("Restaurant ID doesn't exist");
                return menu;
            }
            return getRatingByRestaurantId[id];
        }
       
    }
}
