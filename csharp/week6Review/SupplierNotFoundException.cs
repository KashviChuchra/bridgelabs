using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class SupplierNotFoundException: InventoryException
    {
        public SupplierNotFoundException(string message) : base(message) { }
    }
}
