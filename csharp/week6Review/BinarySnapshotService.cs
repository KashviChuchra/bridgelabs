using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class BinarySnapshotService
    {
        public void WriteSnapshot(IEnumerable<PurchaseOrder> orders, string filePath)
        {
            using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            using BinaryWriter writer = new BinaryWriter(fileStream);

            List<PurchaseOrder> list = orders.ToList();

            writer.Write(list.Count);

            foreach (PurchaseOrder order in list)
            {
                writer.Write(order.Sku);
                writer.Write(order.ItemName);
                writer.Write(order.SupplierId);
                writer.Write(order.SupplierName);
                writer.Write(order.Quantity);
                writer.Write(order.LeadDays);
            }
        }

        public List<PurchaseOrder> ReadSnapshot(string filePath)
        {
            using FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using BinaryReader reader = new BinaryReader(fileStream);
            int count = reader.ReadInt32();
            List<PurchaseOrder> orders = new List<PurchaseOrder>(count);

            for (int i = 0; i < count; i++)
            {
                orders.Add(new PurchaseOrder(
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadInt32(),
                        reader.ReadInt32()
                        )
                );
            }
            return orders;
        }

        public MemoryStream CreateSnapshotStream(IEnumerable<PurchaseOrder> orders)
        {
            MemoryStream stream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(stream, Encoding.UTF8, true);

            List<PurchaseOrder> list = orders.ToList();

            writer.Write(list.Count);

            foreach (PurchaseOrder order in list)
            {
                writer.Write(order.Sku);
                writer.Write(order.ItemName);
                writer.Write(order.SupplierId);
                writer.Write(order.SupplierName);
                writer.Write(order.Quantity);
                writer.Write(order.LeadDays);
            }

            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public List<PurchaseOrder> ReadSnapshotFromStream(Stream stream)
        {
            stream.Position = 0;

            using BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, true);

            int count = reader.ReadInt32();

            List<PurchaseOrder> orders = new List<PurchaseOrder>(count);

            for (int i = 0; i < count; i++)
            {
                orders.Add(new PurchaseOrder(
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadString(),
                        reader.ReadInt32(),
                        reader.ReadInt32()
                        )
                );
            }

            return orders;
        }

    }
}
