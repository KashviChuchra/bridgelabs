using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class SupplierSummary
    {
        public string SupplierId { get; set; } = String.Empty;
        public string SupplierName { get; set; } = String.Empty;
        public int PurchaseOrderCount { get; set; }
        public int TotalUnits { get; set; }

        public SupplierSummary()
        {

        }

        public SupplierSummary(string supplierId, string supplierName)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
        }
    }
}
