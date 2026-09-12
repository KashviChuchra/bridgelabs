using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class FoodDeliverySystem
    {
        private readonly Stack<Order> cancellationStack = new Stack<Order>();
        private readonly Queue<Order> orderQueue=new Queue<Order>();
        private readonly Dictionary<int, Order> orders = new Dictionary<int, Order>();
        private readonly Dictionary<int, Restaurant> restaurants = new Dictionary<int, Restaurant>();

        private readonly RiderRotation riderRotation =new RiderRotation();
        private readonly DeliveryRoute deliveryRoute =new DeliveryRoute();
        public void AddRestaurant(Restaurant restaurant)
        {
            if (restaurant == null) throw new ArgumentNullException(nameof(restaurant));
            restaurants[restaurant.RestaurantID] = restaurant;
        }

        public Restaurant GetRestaurant(int restaurantId)
        {
            if (!restaurants.ContainsKey(restaurantId)) throw new KeyNotFoundException("Invalid Rest ID");

            return restaurants[restaurantId];
        }
        public List<MenuItem> GetMenu(int restaurantId)
        {
            return GetRestaurant(restaurantId).Menu;
        }

        public void PlaceOrder(Order order)
        {
            if(order==null) throw new ArgumentNullException(nameof(order));
            if (orders.ContainsKey(order.OrderId))  throw new InvalidOperationException("Order ID already exists");
            order.Status = "Pending";
            orderQueue.Enqueue(order);
            orders[order.OrderId] = order;
        }

        public Order ProcessNextOrder()
        {
            if (orderQueue.Count == 0) throw new InvalidOperationException("Order queue is empty");
            Order order = orderQueue.Dequeue();
            order.Status = "Processing";

            return order;
        }
        public string GetOrderStatus(int orderId)
        {
            if (!orders.ContainsKey(orderId)) throw new KeyNotFoundException("Invalid Order ID");

            return orders[orderId].Status;
        }
        public void AddRider(Rider rider)
        {
            if (rider == null)  throw new ArgumentNullException(nameof(rider));

            riderRotation.AddRider(rider);
        }

        public Rider AssignRider(int orderId)
        {
            if (!orders.TryGetValue(orderId, out Order order))  throw new KeyNotFoundException("Invalid Order ID");

            if (order.Status == "Cancelled")    throw new InvalidOperationException("Cannot assign rider to cancelled order");

            if (!riderRotation.HasRiders()) return null;

            Rider rider = riderRotation.GetNextRider();
            order.RiderId = rider.RiderId;
            return rider;
        }
        public void CancelOrder(int orderId)
        {
            if (!orders.TryGetValue(orderId, out Order order)) throw new KeyNotFoundException("Order id  doesnot fou");
            if (order.Status == "Cancelled") throw new InvalidOperationException("Order status is Already Caancelled!");

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

        public void AddWaypoint(int waypoint)
        {
            deliveryRoute.AddWaypoint(waypoint);
        }

        public int GetCurrentWaypoint()
        {
            return deliveryRoute.GetCurrentWaypoint();
        }

        public int MoveForward()
        {
            return deliveryRoute.MoveForward();
        }

        public int MoveBackward()
        {
            return deliveryRoute.MoveBackward();
        }

        public void Reroute(int existingWaypoint, int newWaypoint)
        {
            deliveryRoute.Reroute(existingWaypoint, newWaypoint);
        }

        public List<int> GetRoute()
        {
            return deliveryRoute.GetRoute();
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
            List<MenuItem> menu = restaurant.Menu.OrderBy(m => m.Price).ToList();

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
