using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    internal class RiderNode
    {
        public Rider Rider { get; set;}
        public RiderNode next { get; set;}
        public RiderNode(Rider rider)
        {
            Rider= rider;
        }

        public Rider AssignNextRider(RouteNode currentRider)
        {
            if (currentRider == null) return null;

            Rider rider = currentRider.Rider;
            currentRider = currentRider.next;
            return rider;
        }

    }
}

