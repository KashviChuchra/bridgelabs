using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class PurchaseOrder
    {
        public string Sku { get; set; }
        public string ItemName { get; set;}
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int Quantity { get; set; }
        public int LeadDays { get; set; }

        public PurchaseOrder() { }
        public PurchaseOrder(string sku, string itemName, string supplierId, string supplierName,int quantity,int leadDays) { }

    }
}
