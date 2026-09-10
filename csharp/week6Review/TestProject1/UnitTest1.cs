using InventoryRestockAndPurchaseOrderPlanner;

[TestFixture]
public class InventoryProcessorTests
{
    private InventoryProcessor processor = null!;

    [SetUp]
    public void Setup()
    {
        processor = new InventoryProcessor();
    }

    [Test]
    public void ItemBelowThresholdGeneratesReorder()
    {
        string inventory =
            "Sku,ItemName,QtyOnHand,ReorderThreshold,PreferredSupplierId\n" +
            "SKU1,USB Cable,20,30,SUP1\n";

        string suppliers =
            "{\"suppliers\":[{\"id\":\"SUP1\",\"name\":\"TechSource\",\"leadDays\":3}]}";

        string inventoryPath = CreateTempFile(inventory, ".csv");
        string suppliersPath = CreateTempFile(suppliers, ".json");

        try
        {
            ProcessingResult result =
                processor.Process(inventoryPath, suppliersPath);

            Assert.That(result.PurchaseOrders.Count, Is.EqualTo(1));
            Assert.That(result.PurchaseOrders[0].Sku, Is.EqualTo("SKU1"));
            Assert.That(result.PurchaseOrders[0].Quantity, Is.EqualTo(40));
        }
        finally
        {
            DeleteFile(inventoryPath);
            DeleteFile(suppliersPath);
        }
    }

    [Test]
    public void NegativeQuantityThrowsInvalidQuantityException()
    {
        Assert.Throws<InvalidQuantityException>(
            () => processor.ValidateQuantity(-1));
    }

    [Test]
    public void InvalidReorderThresholdThrowsInventoryException()
    {
        Assert.Throws<InventoryException>(
            () => processor.ValidateThreshold(0));
    }

    [Test]
    public void CorrectReorderQuantity()
    {
        int quantity =
            processor.CalculateReorderQuantity(5, 10);

        Assert.That(quantity, Is.EqualTo(15));
    }

    [Test]
    public void BinarySnapshotRoundTrip()
    {
        List<PurchaseOrder> orders =
        [
            new PurchaseOrder(
                "SKU1",
                "USB Cable",
                "SUP1",
                "TechSource",
                40,
                3),

            new PurchaseOrder(
                "SKU2",
                "HDMI Cable",
                "SUP2",
                "CableWorld",
                15,
                5)
        ];

        BinarySnapshotService service =
            new BinarySnapshotService();

        using MemoryStream stream =
            service.CreateSnapshotStream(orders);

        List<PurchaseOrder> restored =
            service.ReadSnapshotFromStream(stream);

        Assert.That(restored.Count, Is.EqualTo(2));
        Assert.That(restored[0].Sku, Is.EqualTo("SKU1"));
        Assert.That(restored[0].Quantity, Is.EqualTo(40));
        Assert.That(restored[1].Sku, Is.EqualTo("SKU2"));
        Assert.That(restored[1].Quantity, Is.EqualTo(15));
    }

    private static string CreateTempFile(
        string content,
        string extension)
    {
        string path = Path.Combine(
            Path.GetTempPath(),
            $"{Guid.NewGuid()}{extension}");

        File.WriteAllText(path, content);

        return path;
    }

    private static void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}