using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class DuplicateSkuException: InventoryException
    {
        public DuplicateSkuException(string message) : base(message) { }
    }
}
