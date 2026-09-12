using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class SupplierNotFoundException: InventoryException
    {
        public SupplierNotFoundException(string message) : base(message) { }
    }
}
