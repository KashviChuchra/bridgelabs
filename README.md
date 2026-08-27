This is a Readme file of week 4 evaluation => 1 scenario based project using all data structures
# Food Delivery Order Tracking System

## 1. Project Overview

The **Food Delivery Order Tracking System** is a C# application developed to simulate the core operations of a food-delivery platform.

The project demonstrates the practical use of multiple data structures by mapping each real-world operation to a suitable data structure.

The system supports:

* FIFO kitchen order processing
* Delivery route management
* Round-robin rider assignment
* Order cancellation and undo
* Restaurant and menu lookup
* Restaurant sorting
* Menu item binary search
* NUnit-based testing
* Edge-case and integrated workflow handling

The main objective is to demonstrate how different data structures can work together as **one integrated food-delivery system**.

---

## 2. Objectives

The main objectives of the project are:

1. Implement a kitchen order queue using FIFO.
2. Implement a delivery route using a Doubly Linked List.
3. Implement round-robin rider assignment using a Circular Linked List.
4. Implement cancellation and undo functionality using a Stack.
5. Implement fast order and restaurant lookup using Dictionary/HashMap.
6. Implement restaurant sorting based on rating and distance.
7. Implement binary search for menu items sorted by price.
8. Handle required edge cases and invalid operations.
9. Create NUnit tests for individual features and integrated workflows.
10. Analyze the time complexity of the implemented operations.

---

## 3. Technologies Used

* **Language:** C#
* **Framework:** .NET
* **IDE:** Visual Studio
* **Testing Framework:** NUnit
* **Concepts:** Data Structures, Object-Oriented Programming, LINQ, Exception Handling
* **Collections:** Queue, Stack, Dictionary, Linked Lists

---

## 4. Data Structures Used

| Requirement        | Data Structure       | Purpose                      |
| ------------------ | -------------------- | ---------------------------- |
| Kitchen Orders     | Queue                | FIFO order processing        |
| Cancellation/Undo  | Stack                | LIFO cancellation history    |
| Rider Rotation     | Circular Linked List | Round-robin rider assignment |
| Delivery Route     | Doubly Linked List   | Forward/backward movement    |
| Order Lookup       | Dictionary           | OrderID-based lookup         |
| Restaurant Lookup  | Dictionary           | RestaurantID-based lookup    |
| Restaurant Sorting | LINQ Sorting         | Sort by rating/distance      |
| Menu Search        | Binary Search        | Search menu items by price   |

---

## 5. System Architecture

The `FoodDeliverySystem` class acts as the central controller that integrates all the data structures.

```text
                     FoodDeliverySystem
                             |
       ------------------------------------------------
       |             |             |         |        |
     Queue         Stack       Dictionary   CLL      DLL
       |             |             |         |        |
    Orders       Cancellation    Lookup    Riders   Route
       |             |             |       Rotation
       |             |             |
       -------- Order Processing ----------
                       |
                       ↓
                 Rider Assignment
                       |
                       ↓
                 Delivery Route
```

---

## 6. Main Features

### 6.1 Kitchen Order Processing

Orders are stored in a Queue.

When an order is placed:

```text
Order → Enqueue()
```

When the kitchen processes an order:

```text
Order → Dequeue()
```

The Queue follows **FIFO (First In, First Out)**.

Example:

```text
Order 101
Order 102
Order 103

Processing:

101 → 102 → 103
```

---

### 6.2 Delivery Route

The delivery route is implemented using a **Doubly Linked List**.

Each route node contains:

* Current waypoint
* Next waypoint
* Previous waypoint

Example:

```text
10 ⇄ 20 ⇄ 30 ⇄ 40
```

The system supports:

* Adding waypoints
* Moving forward
* Moving backward
* Rerouting
* Retrieving the complete route

For example:

```text
Original:

10 ⇄ 20 ⇄ 30

After rerouting 20 → 25:

10 ⇄ 25 ⇄ 30
```

---

### 6.3 Rider Rotation

Riders are maintained using a **Circular Linked List**.

Example:

```text
Rider 1 → Rider 2 → Rider 3
   ↑                    ↓
   └────────────────────┘
```

Riders are assigned in round-robin order:

```text
Order 1 → Rider 1
Order 2 → Rider 2
Order 3 → Rider 3
Order 4 → Rider 1
Order 5 → Rider 2
```

If no rider is available, the system returns `null`.

---

### 6.4 Cancellation and Undo

A Stack is used to maintain cancelled orders.

Example:

```text
Cancel Order 101
Cancel Order 102
Cancel Order 103

Stack:

103 ← Top
102
101
```

When undo is performed:

```text
103
```

is restored first.

This follows **LIFO (Last In, First Out)**.

---

### 6.5 Order Lookup

A Dictionary is used to maintain:

```text
OrderID → Order
```

This allows the system to retrieve an order using its ID.

Example:

```text
101 → Order 101
102 → Order 102
103 → Order 103
```

Order status can therefore be retrieved using:

```text
GetOrderStatus(OrderID)
```

---

### 6.6 Restaurant and Menu Lookup

Restaurants are maintained using:

```text
RestaurantID → Restaurant
```

Each restaurant maintains its own menu:

```text
Restaurant
    |
    └── Menu
         ├── Burger
         ├── Pizza
         └── Pasta
```

The system supports:

* Adding restaurants
* Retrieving restaurants
* Retrieving menus
* Adding menu items
* Removing menu items

---

### 6.7 Restaurant Sorting

Restaurants can be sorted using two criteria.

#### Rating

Restaurants are sorted in descending order:

```text
4.8
4.5
4.2
4.0
```

#### Distance

Restaurants are sorted in ascending order:

```text
2 km
4 km
7 km
10 km
```

LINQ sorting operations are used for these requirements.

---

### 6.8 Menu Search

Menu items are sorted by price and searched using **Binary Search**.

Example:

```text
Burger  → ₹100
Pasta   → ₹200
Pizza   → ₹300
Biryani → ₹400
```

Searching for ₹300:

```text
Middle → ₹200

₹200 < ₹300
Search right half

Middle → ₹300

Found
```

Binary search has a search complexity of:

```text
O(log n)
```

for already sorted data.

---

## 7. Integrated Workflow

The system integrates all the data structures into one workflow.

### Example

### Step 1 — Customer places an order

```text
Order 101
     ↓
Queue
```

The order status is:

```text
Pending
```

The order is also stored in:

```text
OrderID → Order
```

---

### Step 2 — Kitchen processes the order

The order is removed from the Queue using FIFO.

```text
Pending → Processing
```

---

### Step 3 — Rider is assigned

A rider is selected from the Circular Linked List.

```text
Rider 1 → Rider 2 → Rider 3 → Rider 1
```

---

### Step 4 — Delivery begins

The rider follows the route maintained using the Doubly Linked List.

```text
10 ⇄ 20 ⇄ 30
```

The rider can move forward or backward.

---

### Step 5 — Route changes

If a waypoint becomes unavailable:

```text
10 ⇄ 20 ⇄ 30
```

it can be rerouted:

```text
10 ⇄ 25 ⇄ 30
```

---

### Step 6 — Cancellation

If the customer cancels the order:

```text
Status → Cancelled
```

The order is pushed onto the cancellation Stack.

---

### Step 7 — Undo

If the cancellation is undone:

```text
Stack.Pop()
```

The order status is restored to:

```text
Pending
```

---

## 8. Edge Cases Handled

The system handles the following mandatory edge cases:

### Empty Order Queue

If no orders are available for processing, an `InvalidOperationException` is thrown.

### No Rider

If no rider has been registered, rider assignment returns `null`.

### Cancelled Order

A cancelled order cannot be assigned a rider.

### Route Boundary

Attempting to move backward from the first waypoint or forward from the last waypoint results in an exception.

### Route Change

A specified waypoint can be replaced with a new waypoint.

### Invalid Order ID

An invalid OrderID results in a `KeyNotFoundException`.

### Invalid Restaurant ID

An invalid RestaurantID results in a `KeyNotFoundException`.

### Empty Menu

Searching an empty menu returns `null`.

### Duplicate Order ID

The system prevents duplicate OrderIDs from being inserted.

---

## 9. Project Structure

```text
FoodDelivery
│
├── FoodDeliverySystem.cs
├── Order.cs
├── Restaurant.cs
├── MenuItem.cs
├── Rider.cs
├── RiderNode.cs
├── RiderRotation.cs
├── RouteNode.cs
└── DeliveryRoute.cs
│
└── FoodDeliveryTest
    └── UnitTest1.cs
```

### Class Responsibilities

| Class                | Responsibility                         |
| -------------------- | -------------------------------------- |
| `FoodDeliverySystem` | Central controller and integration     |
| `Order`              | Stores order information               |
| `Restaurant`         | Stores restaurant and menu information |
| `MenuItem`           | Stores menu item details               |
| `Rider`              | Stores rider information               |
| `RiderNode`          | Node for circular rider list           |
| `RiderRotation`      | Manages round-robin rider assignment   |
| `RouteNode`          | Node for delivery route                |
| `DeliveryRoute`      | Manages doubly linked delivery route   |

---

## 10. Complexity Analysis

| Operation         | Data Structure       |   Complexity |
| ----------------- | -------------------- | -----------: |
| Place Order       | Queue + Dictionary   | O(1) average |
| Process Order     | Queue                |         O(1) |
| Assign Rider      | Circular Linked List |         O(1) |
| Add Rider         | Circular Linked List |         O(1) |
| Cancel Order      | Stack + Dictionary   | O(1) average |
| Undo Cancellation | Stack                |         O(1) |
| Order Lookup      | Dictionary           | O(1) average |
| Restaurant Lookup | Dictionary           | O(1) average |
| Move Forward      | Doubly Linked List   |         O(1) |
| Move Backward     | Doubly Linked List   |         O(1) |
| Reroute           | Doubly Linked List   |         O(n) |
| Sort by Rating    | LINQ                 |   O(n log n) |
| Sort by Distance  | LINQ                 |   O(n log n) |
| Binary Search     | Sorted Menu          |     O(log n) |

> **Note:** The menu search method first sorts the menu and then performs binary search. Therefore, the complete method takes O(n log n) because of sorting, while the binary search itself takes O(log n).

---

## 11. Testing

The project uses **NUnit** for automated testing.

The test suite covers:

* Order placement
* FIFO order processing
* Empty queue
* Rider assignment
* No rider scenario
* Round-robin rider rotation
* Order cancellation
* Cancellation undo
* Empty cancellation stack
* Invalid OrderID
* Invalid RestaurantID
* Menu binary search
* Empty menu
* Restaurant sorting by rating
* Restaurant sorting by distance
* Route forward movement
* Route backward movement
* Route rerouting
* Route boundary conditions
* Integrated order-to-rider workflow
* Integrated cancellation and route workflow

The project contains more than the required **10 NUnit tests** and includes at least **2 integrated workflows**.

---

## 12. Integrated Testing Workflow 1

### Order Processing and Rider Assignment

```text
Add Restaurant
      ↓
Add Rider
      ↓
Place Order
      ↓
Queue
      ↓
Process Order
      ↓
Assign Rider
      ↓
Delivery
```

This verifies that the Queue, Dictionary, Order, and Circular Linked List work together.

---

## 13. Integrated Testing Workflow 2

### Cancellation and Route Change

```text
Add Route
      ↓
Place Order
      ↓
Cancel Order
      ↓
Cancellation Stack
      ↓
Undo Cancellation
      ↓
Reroute Delivery
```

This verifies that the Stack, Order system, and Doubly Linked List route work together.

---

## 14. Exception Handling

The system uses exceptions to handle invalid operations.

Examples include:

```text
InvalidOperationException
KeyNotFoundException
ArgumentNullException
```

This prevents invalid operations from silently producing incorrect results.

---

## 15. How to Run the Project

### Prerequisites

* .NET SDK installed
* Visual Studio
* NUnit testing framework
* NUnit test adapter

### Steps

1. Open the solution in Visual Studio.
2. Build the solution.
3. Run the application/project.
4. Open **Test Explorer**.
5. Run all NUnit tests.
6. Verify that all tests pass.

---

## 16. Key Learning Outcomes

Through this project, the following concepts were implemented practically:

* Queue and FIFO processing
* Stack and LIFO processing
* Circular Linked Lists
* Doubly Linked Lists
* Hash-based lookup using Dictionary
* Sorting using LINQ
* Binary Search
* Exception handling
* Object-oriented programming
* Data structure integration
* Unit testing using NUnit
* Edge-case handling
* Complexity analysis

---

## 17. Conclusion

The Food Delivery Order Tracking System demonstrates how different data structures can be applied to solve different real-world problems within a single application.

The project does not use one data structure for every operation. Instead, each structure is selected according to the behavior required by the operation:

* **Queue** for FIFO kitchen processing
* **Circular Linked List** for continuous rider rotation
* **Doubly Linked List** for bidirectional delivery routes
* **Stack** for cancellation and undo
* **Dictionary** for fast ID-based lookup
* **Sorting** for restaurant ranking and distance
* **Binary Search** for efficient menu price searching

The integration of these structures creates a complete food-delivery workflow while also demonstrating their practical advantages, limitations, and time complexities.

Design Pattern

**Start**

↓  

**Customer places an order**

↓  

**Order is added to the Queue**

↓  

**Kitchen processes orders using FIFO**

↓  

**System checks for an available rider**

↓  

**If no rider is available → return “No Rider Available”**

↓  

**If rider is available → assign rider using Circular Linked List**

↓  

**Rider starts delivery**

↓  

**Delivery route is managed using a Doubly Linked List**

↓  

**Rider can move forward or backward through waypoints**

↓  

**If there is a route change → update/reroute the delivery route**

↓  

**Order is delivered**

↓  

**End**

### Cancellation Flow

**Customer cancels order**

↓  

**Order status changes to Cancelled**

↓  

**Cancelled order is pushed onto the Stack**

↓  

**If Undo is requested → Pop the order from Stack**

↓  

**Order status changes back to Pending**

### Lookup Flow

**User provides Order ID / Restaurant ID**

↓  

**Dictionary performs lookup**

↓  

**Order status / Restaurant details are returned**

### Menu Search Flow

**Select Restaurant**

↓  

**Retrieve Menu**

↓  

**Sort menu items by Price**

↓  

**Perform Binary Search**

↓  

**Return matching Menu Item or null**
