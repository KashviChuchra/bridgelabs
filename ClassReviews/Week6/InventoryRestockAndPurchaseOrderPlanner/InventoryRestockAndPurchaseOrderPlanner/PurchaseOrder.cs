using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class PurchaseOrder
    {
        public string Sku { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public string SupplierId { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int LeadDays { get; set; }

        public PurchaseOrder() { }
        public PurchaseOrder(string sku, string itemName, string supplierId, string supplierName, int quantity, int leadDays)
        {
            Sku = sku;
            ItemName = itemName;
            SupplierId = supplierId;
            SupplierName = supplierName;
            Quantity = quantity;
            LeadDays = leadDays;
        }


    }
}