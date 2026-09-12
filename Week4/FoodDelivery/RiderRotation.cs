using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    internal class RiderRotation
    {
        private RiderNode curr;
        private RiderNode tail;

        public void AddRider(Rider rider)
        {
            RiderNode node = new RiderNode(rider);
            if (curr == null)
            {
                curr = node;
                tail = node;
                node.next = node;
                return;
            }
            node.next = curr;
            tail.next = node;
            tail = node;
        }
       
        public Rider GetNextRider()
        {
            if (curr == null) return null;

            Rider rider = curr.Rider;
            curr = curr.next;
            return rider;
        }

        public bool HasRiders()
        {
            return curr != null;
        }

    }
}
