using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class InventoryException : Exception
    {
        public InventoryException(string message) : base(message) { }
    }
}
