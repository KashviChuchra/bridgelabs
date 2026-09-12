using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class Supplier
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int LeadDays { get; set; }

        public Supplier()
        {

        }
        public Supplier(string id, string name, int leadDays)
        {
            Id = id;
            Name = name;
            LeadDays = leadDays;
        }
    }
}