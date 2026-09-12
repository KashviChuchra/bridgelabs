using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class DuplicateSkuException: InventoryException
    {
        public DuplicateSkuException(string message) : base(message) { }
    }
}
