using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class InventoryException : Exception
    {
        public InventoryException(string message) : base(message) { }
    }
}
