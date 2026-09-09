using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int LeadDays { get; set; }

        public Supplier()
        {

        }
        public Supplier(string id, string name,int leadDays)
        {

        }
    }
}
