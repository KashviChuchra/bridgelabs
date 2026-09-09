
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;

namespace InventoryRestockAndPurchaseOrderPlanner
{
    internal class InventoryProcessor1
    {
       
        public ProcessingResult Process(string inventoryPath, string suppliersPath)
        {
            Dictionary<string, Supplier> suppliers = LoadSuppliers(suppliersPath);
            HashSet<string> skuSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>();
            List<Inventory> lowStockItems = new List<Inventory>();
            List<string> errors = new List<string>();

            int processedRecords = 0;
            int invalidRecords = 0;

            using FileStream fileStream = new FileStream(inventoryPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using StreamReader reader = new StreamReader(fileStream);

            string? header = reader.ReadLine();

            if (string.IsNullOrWhiteSpace(header))
            {
                return new ProcessingResult(purchaseOrders, lowStockItems, new List<SupplierSummary>(), errors,0, 0);
            }
            string? line;
            reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                processedRecords++;

                try
                {
                    Inventory item = ParseInventoryItem(line);
                    ValidateSku(item.Sku);

                    if (!skuSet.Add(item.Sku)) new DuplicateSkuException("Duplia=cate sku");
                    ValidateQuantity(item.QntOnHand);
                    ValidateThreshold(item.ReorderThreshold);

                    if (item.QntOnHand<item.ReorderThreshold)
                    {

                        if (suppliers.TryGetValue(item.PreferredSupplierId, out Supplier? supplier)) throw new SupplierNotFoundException($"Supplier id: {item.PreferredSupplierId} not found");
                        int reorderQuantity = CalculateReorderQuantity(item.QntOnHand, item.ReorderThreshold);


                        PurchaseOrder order = new PurchaseOrder(item.Sku, item.ItemName,supplier.Id, supplier.Name,reorderQuantity,supplier.LeadDays);
                        
                        purchaseOrders.Add(order);
                        lowStockItems.Add(item);
                    }
                }
                catch (InventoryException ex)
                {
                    invalidRecords++;
                    errors.Add($"Record: {processedRecords}, Messagee{ex.Message}");
                }
                catch (Exception ex)
                {
                    invalidRecords++;
                    errors.Add($"Record: {processedRecords}, Messagee{ex.Message}");
                }
            }

            List<SupplierSummary> summaries=BuildSupplierSummary(purchaseOrders);
            return new ProcessingResult(purchaseOrders, lowStockItems, summaries, errors, processedRecords, invalidRecords);
        }
        

        public Inventory ParseInventoryItem(string line)
        {
            string[] fields = line.Split(',');
            if (fields.Length != 5) throw new InventoryException("Fields should be 5");
            string sku = fields[0].Trim();
            string itemName = fields[1].Trim();
            string quantityText = fields[2].Trim();
            string thresholdText = fields[3].Trim();
            string supplierId = fields[4].Trim();

            if (string.IsNullOrEmpty(sku)) throw new InventoryException("Sku cant be empty");
            if (string.IsNullOrEmpty(itemName)) throw new InventoryException("Item Name cant be empty");
            if (string.IsNullOrEmpty(quantityText)) throw new InventoryException("quantity  cant be empty");
            if (string.IsNullOrEmpty(thresholdText)) throw new InventoryException("reorder threshold cant be empty");
            if (string.IsNullOrEmpty(supplierId)) throw new InventoryException("supplier Id cant be empty");

            if (!int.TryParse(quantityText, out int quantity)) throw new InventoryException("Invalid Quantity");
            if (!int.TryParse(thresholdText, out int threshold)) throw new InventoryException("Invalid Threshold");


            return new Inventory(sku, itemName, quantity, threshold, supplierId);
         
        }
        public int CalculateReorderQuantity(int quantity, int threshold)
        {
            ValidateQuantity(quantity);
            ValidateThreshold(threshold);
            return (threshold*2)-quantity;
        }

        public void ValidateQuantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new InventoryException("Quantity can't be -ve");
            }
        }

        public void ValidateThreshold(int threshold)
        {
            if (threshold <= 0)
            {
                throw new InventoryException("Threshold can't be -ve");
            }
        }
        public void ValidateSku(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                throw new InventoryException("Sku can't be empty");
            }
        }

        public Dictionary<string, Supplier> LoadSuppliers(string suppliersPath)
        {
            using FileStream fileStream = new FileStream(suppliersPath, FileMode.Open, FileAccess.Read, FileShare.None);
            SupplierContainer? container =JsonSerializer.Deserialize<SupplierContainer>(fileStream);
            if(container == null || container.Suppliers== null) throw new InventoryException("Supplier file is empty");
  
            Dictionary<string, Supplier> suppliers =new Dictionary<string, Supplier>(StringComparer.OrdinalIgnoreCase);

            foreach (Supplier supplier in container.Suppliers)
            {
                if (!string.IsNullOrWhiteSpace(supplier.Id))
                {
                    suppliers[supplier.Id] = supplier;
                }
            }

            return suppliers;
        }

        public List<SupplierSummary> BuildSupplierSummary(List<PurchaseOrder> orders) 
        {
     
            Dictionary<string, SupplierSummary> summary =new Dictionary<string, SupplierSummary>(StringComparer.OrdinalIgnoreCase);

            foreach (PurchaseOrder order in orders)
            {
                if (!summary.TryGetValue(order.SupplierId, out SupplierSummary? supplierSummary))
                {
                    supplierSummary = new SupplierSummary(order.SupplierId, order.SupplierName);
                    summary[order.SupplierId] = supplierSummary;
                }
                supplierSummary.PurchaseOrderCount++;
                supplierSummary.TotalUnits += order.Quantity;
            }

            return summary.Values.OrderBy(x => x.SupplierId).ToList();
        }
    }
}
