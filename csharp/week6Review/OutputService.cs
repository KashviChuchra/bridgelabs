using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class OutputService
    {
        private readonly PurchaseOrderService purchaseOrderService = new PurchaseOrderService();
        public void GeneratePurchaseOrders(List<PurchaseOrder> orders, string outputPath)
        {
            using MemoryStream staged = purchaseOrderService.StagePurchaseOrders(orders);
            purchaseOrderService.WriteStagedOrder(staged, outputPath);
        }

        public void GenerateSupplierSummary(List<SupplierSummary> summaries, string outputPath)
        {
            using FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None);
            using Utf8JsonWriter writer = new Utf8JsonWriter(fileStream, new JsonWriterOptions { Indented = true });
            JsonSerializer.Serialize(writer, summaries);
            writer.Flush();
        }

        public void GenerateLowStockLog(List<Inventory> items, string outputPath)
        {
            using FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None);

            using BufferedStream bufferedStream = new BufferedStream(fileStream);
            using StreamWriter writer = new StreamWriter(bufferedStream, Encoding.UTF8);


            foreach (Inventory item in items)
            {
                int reorderQuantity = (item.ReorderThreshold * 2) - item.QntOnHand;

                writer.WriteLine($"SKU={item.Sku}\tItem={item.ItemName}\tQtyOnHand={item.QntOnHand}\tThreshold={item.ReorderThreshold}\tReorderQty={reorderQuantity}\tSupplier={item.PreferredSupplierId}");

            }
        }

    }
}
