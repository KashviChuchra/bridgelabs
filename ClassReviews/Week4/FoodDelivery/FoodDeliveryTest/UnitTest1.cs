using NUnit.Framework;
using System;
using System.Collections.Generic;
using FoodDelivery;

namespace FoodDeliveryTest
{
    [TestFixture]
    public class UnitTest1
    {
        private FoodDeliverySystem system;

        [SetUp]
        public void Setup()
        {
            system = new FoodDeliverySystem();
        }

        [Test]
        public void PlaceOrder()
        {
            Order order = new Order
            {
                OrderId = 1,
                RestaurantId = 100
            };

            system.PlaceOrder(order);

            Assert.That(system.GetOrderStatus(1),Is.EqualTo("Pending"));
        }

        [Test]
        public void ProcessOrder()
        {
            system.PlaceOrder(new Order { OrderId = 1 });
            system.PlaceOrder(new Order { OrderId = 2 });

            Order first = system.ProcessNextOrder();

            Assert.That(first.OrderId, Is.EqualTo(1));
        }

        [Test]
        public void ProcessEmptyQueue()
        {
            Assert.Throws<InvalidOperationException>(
                () => system.ProcessNextOrder());
        }

        [Test]
        public void AssignRider_ReturnsRider()
        {
            system.AddRider(new Rider
            {
                RiderId = 10,
                Name = "Rahul"
            });

            system.PlaceOrder(new Order
            {
                OrderId = 1
            });

            Rider rider = system.AssignRider(1);

            Assert.That(rider, Is.Not.Null);
            Assert.That(rider.RiderId, Is.EqualTo(10));
        }

        [Test]
        public void AssignRider_If_NoRider_ReturnsNull()
        {
            system.PlaceOrder(new Order
            {
                OrderId = 1
            });

            Rider rider = system.AssignRider(1);

            Assert.That(rider,Is.Null);
        }

        [Test]
        public void RiderRotation_IsRoundRobin()
        {
            system.AddRider(new Rider(1, "Rider 1"));
            system.AddRider(new Rider(2, "Rider 2"));

            system.PlaceOrder(new Order { OrderId = 1 });
            system.PlaceOrder(new Order { OrderId = 2 });
            system.PlaceOrder(new Order { OrderId = 3 });

            Rider rider1 = system.AssignRider(1);
            Rider rider2 = system.AssignRider(2);
            Rider rider3 = system.AssignRider(3);

            Assert.That(rider1.RiderId, Is.EqualTo(1));
            Assert.That(rider2.RiderId, Is.EqualTo(2));
            Assert.That(rider3.RiderId, Is.EqualTo(1));
        }

        [Test]
        public void CancelOrder()
        {
            system.PlaceOrder(new Order{OrderId = 1});

            system.CancelOrder(1);

            Assert.That(system.GetOrderStatus(1),Is.EqualTo("Cancelled"));
        }

        [Test]
        public void UndoCancellation()
        {
            system.PlaceOrder(new Order{OrderId = 1});

            system.CancelOrder(1);
            system.UndoCancellation();

            Assert.That(system.GetOrderStatus(1),Is.EqualTo("Pending"));
        }

        [Test]
        public void InvalidOrderId()
        {
            Assert.Throws<KeyNotFoundException>(
                () => system.GetOrderStatus(999));
        }

       

        [Test]
        public void SearchMenuItemByPrice_FindsItem()
        {
            Restaurant restaurant = new Restaurant
            {
                RestaurantID = 1,
                Name = "Pizza Hub",
                Menu = new List<MenuItem>
                {
                    new MenuItem{ItemId = 1,Name = "Burger",Price = 100},
                    new MenuItem{ItemId = 2,Name = "Pizza",Price = 300},
                }
            };

            system.AddRestaurant(restaurant);

            MenuItem item =system.SearchMenuItemByPrice(1, 200);

            Assert.That(item, Is.Not.Null);
            Assert.That(item.Name, Is.EqualTo("Pizza"));
        }
        [Test]
        public void IntegratedWorkflow1()
        {
            Restaurant restaurant =new Restaurant(1, "First Coffee", 4.5, 3);

            restaurant.AddFoodItemInMenu(101,"Chessy Fries",2,130);

            system.AddRestaurant(restaurant);
            system.AddRider(new Rider(10, "Abhay"));

            Order order = new Order
            {
                OrderId = 1,
                RestaurantId = 1,
                Amount = 150
            };

            system.PlaceOrder(order);
            Order processed =system.ProcessNextOrder();
            Rider rider =system.AssignRider(processed.OrderId);

            Assert.That(processed.OrderId,Is.EqualTo(1));

            Assert.That(processed.Status,Is.EqualTo("Processing"));

            Assert.That(rider.RiderId,Is.EqualTo(10));
        }


        [Test]
        public void IntegratedWorkflow2()
        {
            system.AddWaypoint(100);
            system.AddWaypoint(200);
            system.AddWaypoint(300);

            Order order = new Order
            {
                OrderId = 50
            };

            system.PlaceOrder(order);
            system.CancelOrder(50);
            Assert.That(system.GetOrderStatus(50), Is.EqualTo("Cancelled"));
            system.UndoCancellation();
            Assert.That(system.GetOrderStatus(50),Is.EqualTo("Pending"));
            system.Reroute(200, 250);
            Assert.That(system.GetRoute(),Is.EqualTo(new List<int>{100, 250, 300}));
        }
    }
}