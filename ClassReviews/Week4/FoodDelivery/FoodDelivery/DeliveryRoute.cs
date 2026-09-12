using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class DeliveryRoute
    {
        private RouteNode head;
        private RouteNode tail;
        private RouteNode current;

        public void AddWaypoint(int waypoint)
        {
            RouteNode node = new RouteNode(waypoint);

            if (head == null)
            {
                head = node;
                tail = node;
                current = node;

                return;
            }

            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }

        public int GetCurrentWaypoint()
        {
            if (current == null)    throw new InvalidOperationException("Route is empty");

            return current.Value;
        }

        public int MoveForward()
        {
            if (current == null)    throw new InvalidOperationException("Route is empty");

            if (current.Next == null)   throw new InvalidOperationException("At last waypoint");

            current = current.Next;
            return current.Value;
        }

        public int MoveBackward()
        {
            if (current == null)    throw new InvalidOperationException("Route is empty");

            if (current.Prev == null)   throw new InvalidOperationException("At first waypoint");

            current = current.Prev;
            return current.Value;
        }

        public void Reroute(int oldWayPoint, int newWaypoint)
        {
            RouteNode temp = head;

            while (temp != null)
            {
                if (temp.Value == oldWayPoint)
                {
                    temp.Value = newWaypoint;
                    return;
                }

                temp = temp.Next;
            }

            throw new KeyNotFoundException("Waypoint not found");
        }

        public List<int> GetRoute()
        {
            List<int> route = new List<int>();

            RouteNode temp = head;

            while (temp != null)
            {
                route.Add(temp.Value);
                temp = temp.Next;
            }

            return route;
        }
    }
}
