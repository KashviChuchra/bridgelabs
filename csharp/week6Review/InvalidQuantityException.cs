using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class InvalidQuantityException: InventoryException
    {
        public InvalidQuantityException(string message) : base(message) { }
    }
}
