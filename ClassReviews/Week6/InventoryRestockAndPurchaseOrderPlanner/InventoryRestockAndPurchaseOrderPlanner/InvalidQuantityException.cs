using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class InvalidQuantityException: InventoryException
    {
        public InvalidQuantityException(string message) : base(message) { }
    }
}
