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

            Assert.That("Pending", Is.EqualTo(system.GetOrderStatus(1)));
        }

        [Test]
        public void ProcessOrder()
        {
            system.PlaceOrder(new Order { OrderId = 1 });
            system.PlaceOrder(new Order { OrderId = 2 });

            Order first = system.ProcessNextOrder();

            Assert.That(1, Is.EqualTo(first.OrderId));
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

            Assert.That(rider,Is.Not.Null);
            Assert.That(10, Is.EqualTo(rider.RiderId));
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
        public void CancelOrder()
        {
            system.PlaceOrder(new Order{OrderId = 1});

            system.CancelOrder(1);

            Assert.That("Cancelled",Is.EqualTo(system.GetOrderStatus(1)));
        }

        [Test]
        public void UndoCancellation()
        {
            system.PlaceOrder(new Order{OrderId = 1});

            system.CancelOrder(1);
            system.UndoCancellation();

            Assert.That("Pending",Is.EqualTo(system.GetOrderStatus(1)));
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
                RestaurantId = 1,
                Name = "Pizza Hub",
                Menu = new List<MenuItem>
                {
                    new MenuItem{ItemId = 1,Name = "Burger",Price = 100},
                    new MenuItem{ItemId = 2,Name = "Pizza",Price = 300},
                }
            };

            system.AddRestaurant(restaurant);

            MenuItem item =system.SearchMenuItemByPrice(1, 200);

            Assert.That(item,Is.Not.Null);
            Assert.That("Pizza", Is.EqualTo(item.Name));
        }
    }
}