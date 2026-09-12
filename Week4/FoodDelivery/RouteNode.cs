using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class RouteNode
    {
        public int val;
        public RouteNode next;
        public RouteNode prev;

        public RouteNode(int val) 
        {
            this.val = val;
            next = null;
            prev = null;
        }


        public void MoveForward(RouteNode node)
        {
            if (node == null)
            {
                throw new InvalidOperationException("At last position");
            }
            node = node.next;
        }
        public void MoveBackward(RouteNode node)
        {
            if(node.prev== null) throw new InvalidOperationException("At First position");
            node=node.prev;
        }
        public void Reroute(int existingWaypoint, int newWaypoint, RouteNode head )
        {
            RouteNode temp = head;

            while (temp != null)
            {
                if (temp.val == existingWaypoint)
                {
                    temp.val = newWaypoint;
                    return;
                }

                temp = temp.next;
            }

            throw new KeyNotFoundException("waypoint not found");
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
