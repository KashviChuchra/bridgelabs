using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    internal class FoodDeliverySystem
    {
        private readonly Stack<Order> cancellationStack = new Stack<Order>();
        private readonly Queue<Order> orderQueue=new Queue<Order>();
        private readonly Dictionary<int, Order> orders = new();
        private readonly Dictionary<int, Restaurant> restaurants = new();

        public void AddRestaurant(Restaurant restaurant)
        {
            restaurants[restaurant.RestaurantID] = restaurant;
        }

        public Restaurant GetRestaurant(int restaurantId)
        {
            if (!restaurants.ContainsKey(restaurantId)) throw new KeyNotFoundException("Invalid Rest ID");

            return restaurants[restaurantId];
        }
        public List<MenuItem> GetMenu(int restaurantId)
        {
            return GetRestaurant(restaurantId).menu;
        }

        public void PlaceOrder(Order order)
        {
            orderQueue.Enqueue(order);
            orders[order.OrderId] = order;
        }
        public void CancelOrder(int orderId)
        {
            if (!orders.TryGetValue(orderId, out Order order)) throw new KeyNotFoundException("Order id  doesnot fou");
            if (order.Status == "Cancelled") throw new InvalidOperationException("Order status is Already Cancelled!");

            order.Status = "Cancelled";
            cancellationStack.Push(order);
        }
        public Order UndoCancellation()
        {
            if (cancellationStack.Count == 0) throw new InvalidOperationException("Nothing to undo");

            Order order = cancellationStack.Pop();
            order.Status = "Pending";
            return order;
        }
        public Order ProcessNextOrder()
        {
            if (orderQueue.Count == 0)  throw new InvalidOperationException("Order queue is empty");
            Order order = orderQueue.Dequeue();
            order.Status = "Processing";

            return order;
        }

        public string GetOrderStatus(int orderId)
        {
            if (!orders.ContainsKey(orderId))   throw new KeyNotFoundException("Invalid Order ID");

            return orders[orderId].Status;
        }

        public List<Restaurant> SortRestaurantByRating()
        {
            return restaurants.Values.OrderByDescending(i=>i.Rating).ToList();
        }
        public List<Restaurant> SortRestaurantByDistance()
        {
            return restaurants.Values.OrderBy(i => i.Distance).ToList();
        }

        public MenuItem SearchMenuItemByPrice(int restaurantId,double target)
        {
            Restaurant restaurant = GetRestaurant(restaurantId);
            List<MenuItem> menu = restaurant.menu.OrderBy(m => m.Price).ToList();

            if (menu.Count == 0)    return null;

            int left = 0;
            int right = menu.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (menu[mid].Price == target)
                {
                    return menu[mid] ;
                }
                else if (menu[mid].Price > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return null;
        }
    }
}
