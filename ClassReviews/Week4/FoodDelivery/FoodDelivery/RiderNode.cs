using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class RiderNode
    {
        public Rider Rider { get; set;}
        public RiderNode next { get; set;}
        public RiderNode(Rider rider)
        {
            Rider= rider;
            next = null;
        }

        

    }
}

