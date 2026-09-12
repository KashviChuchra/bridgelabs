using System;
namespace InventoryRestockAndPurchaseOrderPlanner;

class Program
{
    public static void Main(string[] args)
    {

        string inventoryPath = @"C:\Users\chuch\OneDrive\Desktop\file\inventory.csv";
        string suppliersPath = @"C:\Users\chuch\OneDrive\Desktop\file\suppliers.json";


        try
        {
            if (!File.Exists(inventoryPath) || !File.Exists(suppliersPath))
            {
                Console.WriteLine("Required files are missing.");
                return;
            }


            InventoryProcessor processor = new InventoryProcessor();
            ProcessingResult result = processor.Process(inventoryPath, suppliersPath);
            Console.WriteLine("Processing Result done");

            OutputService outputService = new OutputService();

            outputService.GeneratePurchaseOrders(result.PurchaseOrders, @"C:\Users\chuch\OneDrive\Desktop\file\purchase_orders.json");

            outputService.GenerateSupplierSummary(result.Summaries, @"C:\Users\chuch\OneDrive\Desktop\file\supplier_summary.json");

            outputService.GenerateLowStockLog(result.LowStockItems, @"C:\Users\chuch\OneDrive\Desktop\file\low_stock.log");

            BinarySnapshotService snapshotService = new BinarySnapshotService();
            string snapshotPath = @"C:\Users\chuch\OneDrive\Desktop\file\reorder_snapshot.bin";
            snapshotService.WriteSnapshot(result.PurchaseOrders,snapshotPath);
            List<PurchaseOrder> restoredOrders =snapshotService.ReadSnapshot(snapshotPath);

            Console.WriteLine($"Records processed: {result.ProcessedRecords}");
            Console.WriteLine($"Invalid records: {result.InvalidRecords}");
            Console.WriteLine($"Purchased orders generted record: {result.PurchaseOrders.Count}");
            Console.WriteLine($"Binary snapshot records: {restoredOrders.Count}");

            foreach (string error in result.Errors)
            {
                Console.WriteLine(error);
            }

            Console.WriteLine("Processing completed.");
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }

    }
}