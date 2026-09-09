using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class Inventory
    {
        public string Sku { get; set; } = String.Empty;
        public string ItemName { get; set; } = String.Empty;
        public int QntOnHand { get; set; }
        public int ReorderThreshold { get; set; }
        public string PreferredSupplierId { get; set; } = String.Empty;

        public Inventory()
        {

        }

        public Inventory(string sku,string itemName, int qntOnHand, int reorderThreshold, string preferredSuplierId)
        {

        }
       



   
    }
}
