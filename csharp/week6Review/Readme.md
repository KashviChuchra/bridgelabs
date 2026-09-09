# Inventory Restock & Purchase Order Planner

## Problem Overview

The application reads inventory data from `inventory.csv` and supplier data from `suppliers.json`.

For every inventory item:

* Validate the input.
* Check whether `QtyOnHand < ReorderThreshold`.
* If yes, calculate the reorder quantity.
* Find the preferred supplier.
* Create a purchase order.
* Generate the required output files.
* Create and verify a binary reorder snapshot.

---

# Solution Approach — 7 Steps

The complete solution is divided into these 7 steps:

  1. Create Models & Exceptions
  2. Load Supplier Data
  3. Read & Parse Inventory CSV
  4. Validate & Process Inventory
  5. Build Purchase Orders & Supplier Summary
  6. Generate Output Files
  7. Create & Read Binary Snapshot




# Step 1 — Create Models & Exceptions

First, create classes to represent all the data used by the application.

### Models

### `InventoryItem`

Represents one row from `inventory.csv`.

```text
Sku
ItemName
QtyOnHand
ReorderThreshold
PreferredSupplierId
```

### `Supplier`

Represents one supplier from `suppliers.json`.

```text
Id
Name
LeadDays
```

### `SupplierContainer`

Represents the root object of `suppliers.json`.

```text
Suppliers → List<Supplier>
```

### `PurchaseOrder`

Represents a reorder that needs to be placed.

```text
Sku
ItemName
SupplierId
SupplierName
Quantity
LeadDays
```

### `SupplierSummary`

Stores supplier-wise aggregation.

```text
SupplierId
SupplierName
PurchaseOrderCount
TotalUnits
```

### `ProcessingResult`

Stores all results generated during processing.

```text
PurchaseOrders
LowStockItems
Summaries
Errors
ProcessedRecords
InvalidRecords
```

### Custom Exceptions

Create the required exception hierarchy:

```text
InventoryException
├── InvalidQuantityException
├── SupplierNotFoundException
└── DuplicateSkuException
```

---

# Step 2 — Load Supplier Data

Before processing inventory, load `suppliers.json`.

### Flow

```text
suppliers.json
      ↓
FileStream
      ↓
JsonSerializer.Deserialize
      ↓
SupplierContainer
      ↓
Dictionary<string, Supplier>
```

Store suppliers in a dictionary:

```text
SUP1 → TechSource
SUP2 → CableWorld
SUP3 → DisplayHub
```

This allows quick supplier lookup using the supplier ID.

For example:

```text
SUP1 → Supplier object
```

If an inventory item refers to a supplier that does not exist, throw:

```text
SupplierNotFoundException
```

---

# Step 3 — Read & Parse Inventory CSV

Read `inventory.csv` using:

```text
FileStream
    ↓
StreamReader
```

Read the file **record-by-record** using:

```csharp
reader.ReadLine()
```

First read the header and skip it.

Then process every inventory record.

### Example

```text
SKU1,USB Cable,20,30,SUP1
```

Split the record into 5 fields:

```text
SKU1
USB Cable
20
30
SUP1
```

Convert the numeric fields using `int.TryParse()`.

Then create an:

```text
InventoryItem
```

### Validate basic input

Check:

* Exactly 5 fields
* SKU is not empty
* Item name is not empty
* Quantity is not empty
* Threshold is not empty
* Supplier ID is not empty
* Quantity is a valid integer
* Threshold is a valid integer

---

# Step 4 — Validate & Process Inventory

After parsing each record, perform validation.

### 4.1 Validate SKU

SKU cannot be empty.

### 4.2 Check Duplicate SKU

Use:

```text
HashSet<string>
```

If the SKU already exists:

```text
DuplicateSkuException
```

### 4.3 Validate Quantity

```text
QtyOnHand < 0
```

→

```text
InvalidQuantityException
```

### 4.4 Validate Threshold

```text
ReorderThreshold <= 0
```

→ Invalid threshold.

### 4.5 Check Restock Condition

The main business rule is:

```text
QtyOnHand < ReorderThreshold
```

If false:

```text
No purchase order
```

If true:

```text
Continue to supplier lookup
```

### 4.6 Find Supplier

Use the supplier dictionary.

```text
PreferredSupplierId
        ↓
Dictionary lookup
        ↓
Supplier
```

If supplier does not exist:

```text
SupplierNotFoundException
```

---

# Step 5 — Build Purchase Orders & Supplier Summary

## 5.1 Calculate Reorder Quantity

Use:

```text
ReorderQty =
(ReorderThreshold × 2) - QtyOnHand
```

Example:

```text
QtyOnHand = 20
Threshold = 30

ReorderQty = (30 × 2) - 20
           = 40
```

Create a `PurchaseOrder` using:

```text
SKU
Item name
Supplier ID
Supplier name
Reorder quantity
Lead days
```

Add it to:

```text
PurchaseOrders
```

Also add the inventory item to:

```text
LowStockItems
```

---

## 5.2 Build Supplier-wise Summary

After processing all records, group the purchase orders by supplier.

For each supplier calculate:

```text
PurchaseOrderCount
TotalUnits
```

Example:

```text
SUP1
Purchase Orders = 2
Total Units = 70
```

Use:

```text
Dictionary<string, SupplierSummary>
```

for the aggregation.

---

# Step 6 — Generate Output Files

Three outputs are required.

## 6.1 `purchase_orders.json`

Purchase orders must be staged using:

```text
MemoryStream
```

Flow:

```text
PurchaseOrders
      ↓
Utf8JsonWriter
      ↓
MemoryStream
      ↓
FileStream
      ↓
purchase_orders.json
```

Important:

After writing to the `MemoryStream`:

```csharp
memoryStream.Position = 0;
```

Then copy the stream to the output file.

---

## 6.2 `supplier_summary.json`

Write the supplier summaries as JSON.

Flow:

```text
SupplierSummary
      ↓
JsonSerializer
      ↓
FileStream
      ↓
supplier_summary.json
```

---

## 6.3 `low_stock.log`

The low-stock log must use `BufferedStream`.

Flow:

```text
InventoryItem
      ↓
StreamWriter
      ↓
BufferedStream
      ↓
FileStream
      ↓
low_stock.log
```

For every low-stock item, write:

```text
SKU
Item
QtyOnHand
Threshold
ReorderQty
Supplier
```

---

# Step 7 — Create & Read Binary Snapshot

Create:

```text
reorder_snapshot.bin
```

using:

```text
FileStream
    ↓
BinaryWriter
```

Write:

```text
Number of purchase orders
        ↓
For each order:
    SKU
    ItemName
    SupplierId
    SupplierName
    Quantity
    LeadDays
```

Then read the snapshot using:

```text
FileStream
    ↓
BinaryReader
```

Read the values in the **same order** in which they were written.

### Binary Round-trip

```text
PurchaseOrders
      ↓
BinaryWriter
      ↓
reorder_snapshot.bin
      ↓
BinaryReader
      ↓
Restored PurchaseOrders
```

The restored data should match the original data.

---

# Complete Execution Flow

```text
                    inventory.csv
                         ↓
                  FileStream
                         ↓
                  StreamReader
                         ↓
                  Parse CSV row
                         ↓
                    Validate
                         ↓
              ┌──────────┴──────────┐
              │                     │
         Invalid record        Valid record
              │                     │
          Store error          Qty < Threshold?
                                    │
                             ┌──────┴──────┐
                             │             │
                            NO            YES
                             │             │
                           Skip       Find Supplier
                                           │
                                    Calculate Quantity
                                           │
                                    Create PurchaseOrder
                                           │
                                    Add to collections
                                           ↓
                              Build Supplier Summary
                                           ↓
                    ┌──────────────────────┼─────────────────────┐
                    ↓                      ↓                     ↓
             MemoryStream             JSON Summary        BufferedStream
                    ↓                                            ↓
          purchase_orders.json                              low_stock.log

                    PurchaseOrders
                          ↓
                    BinaryWriter
                          ↓
                 reorder_snapshot.bin
                          ↓
                    BinaryReader
                          ↓
                 Restored Orders
```

---

# Important Rules

```text
Restock:
QtyOnHand < ReorderThreshold

Reorder Quantity:
(ReorderThreshold × 2) - QtyOnHand

Negative Quantity:
InvalidQuantityException

Unknown Supplier:
SupplierNotFoundException

Duplicate SKU:
DuplicateSkuException
```

---

# Required I/O Concepts

| Requirement             | Implementation                  |
| ----------------------- | ------------------------------- |
| Read inventory CSV      | `FileStream + StreamReader`     |
| Read suppliers JSON     | `FileStream + JsonSerializer`   |
| Duplicate detection     | `HashSet`                       |
| Supplier lookup         | `Dictionary`                    |
| Purchase-order staging  | `MemoryStream`                  |
| Purchase-order JSON     | `Utf8JsonWriter`                |
| Supplier summary        | `Dictionary + aggregation`      |
| Low-stock log           | `BufferedStream + StreamWriter` |
| Binary snapshot writing | `BinaryWriter`                  |
| Binary snapshot reading | `BinaryReader`                  |

