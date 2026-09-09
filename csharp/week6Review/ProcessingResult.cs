using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class ProcessingResult
    {
        public List<PurchaseOrder> PurchaseOrders { get; }
        public List<Inventory> LowStockItems { get; }
        public List<SupplierSummary> Summaries { get; }
       
        public List<string> Errors { get; }
        public int ProcessedRecords { get; }
        public int InvalidRecords { get; }

        public ProcessingResult() { }
        public ProcessingResult(List<PurchaseOrder> PurchaseOrders, List<Inventory> LowStockItems, List<SupplierSummary> Summaries, List<string> Errors, int ProcessedRecords, int InvalidRecords) { }

    }

}


