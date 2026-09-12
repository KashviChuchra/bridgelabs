using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    public class PurchaseOrderService
    {
        public MemoryStream StagePurchaseOrders(IEnumerable<PurchaseOrder> orders)
        {
            MemoryStream memoryStream = new MemoryStream();

            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream, new JsonWriterOptions { Indented=true });
            writer.WriteStartArray();

            foreach (PurchaseOrder order in orders)
            {
                JsonSerializer.Serialize(writer, order);
            }

            writer.WriteEndArray();
            writer.Flush();

            memoryStream.Position = 0;
            return memoryStream;
        }

        public void WriteStagedOrder(MemoryStream stream,string outputPath)
        {
            stream.Position = 0;

            using FileStream output = new FileStream(outputPath, FileMode.Create,FileAccess.Write, FileShare.None);
            stream.CopyTo(output);
        }
    }
}

