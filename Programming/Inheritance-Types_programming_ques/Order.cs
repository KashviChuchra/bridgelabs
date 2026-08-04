using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Order(int id, DateTime date)
        {
            OrderId = id;
            OrderDate = date;
        }

        public virtual void OrderStatus()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate}");
        }

    }
    internal class ShippedOrder : Order
    {
        public int TrackngNumber
        {
            get; set;
        }
        public ShippedOrder(int id, DateTime date, int trackingNumber) : base(id, date)
        {
            TrackngNumber = trackingNumber;
        }
        public override void OrderStatus()
        {
            base.OrderStatus();
            Console.WriteLine($"Tracking Number: {TrackngNumber}");
        }
    }
    internal class DelieveredOrder : ShippedOrder
    {
        public DateTime delieveryDate { get; set; }
        public DelieveredOrder(int id, DateTime date, int trackingNumber, DateTime delieveryDate) : base(id, date, trackingNumber)
        {
            this.delieveryDate = delieveryDate;
        }
        public override void OrderStatus()
        {
            base.OrderStatus();
            Console.WriteLine($"Delivery Date: {delieveryDate}");
        }

    }
    
}
