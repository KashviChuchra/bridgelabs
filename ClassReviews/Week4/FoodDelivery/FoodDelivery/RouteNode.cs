using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery
{
    public class RouteNode
    {
        public int Value { get; set; }
        public RouteNode Next { get; set; }
        public RouteNode Prev { get; set; }

        public RouteNode(int val) 
        {
            Value = val;
            Next = null;
            Prev = null;
        }


      
        
    }
           
}
