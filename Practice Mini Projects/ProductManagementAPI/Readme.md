# Product Management API

A RESTful Web API built using **C# and ASP.NET Core** for managing products. The project follows a layered architecture to separate API handling, business logic, and data access.

## Features

* Add a new product
* Get a product by ID
* Get all products
* Update an existing product
* Delete a product
* Search products by category
* Product validation
* Dependency Injection
* Layered architecture
* API testing using Postman

## Technologies Used

* C#
* ASP.NET Core Web API
* .NET
* REST API
* Dependency Injection
* Data Annotations
* Postman
* Git & GitHub

## Project Architecture

The project follows a layered architecture:

```text
Client
   ↓
Controller Layer
   ↓
Business Layer
   ↓
Repository Layer
   ↓
In-Memory Data
```

### Controller Layer

The Controller Layer handles HTTP requests and returns HTTP responses.

```text
ProductController
```

### Business Layer

The Business Layer contains the application/business logic and communicates with the Repository Layer.

```text
IProductBL
ProductBL
```

### Repository Layer

The Repository Layer handles product data operations.

```text
IProductRL
ProductRL
```

Currently, product data is stored in an in-memory `List<Product>` instead of a database.

### Model Layer

The Model Layer contains the `Product` model.

```text
Product
├── ProductId
├── ProductName
├── Category
├── Price
└── Quantity
```

## Project Structure

```text
ProductManagementAPI/
│
├── Controllers/
│   └── ProductController.cs
│
├── ModelLayer/
│   └── Product.cs
│
├── BusinessLayer/
│   ├── Interface/
│   │   └── IProductBL.cs
│   └── Service/
│       └── ProductBL.cs
│
├── RepositoryLayer/
│   ├── Interface/
│   │   └── IProductRL.cs
│   └── Service/
│       └── ProductRL.cs
│
├── screenshots/
│   ├── add-product.png
│   ├── get-all-products.png
│   ├── get-product-by-id.png
│   ├── update-product.png
│   ├── search-by-category.png
│   ├── delete-product.png
│   └── validation.png
│
├── Program.cs
├── ProductManagementAPI.csproj
└── README.md
```

## API Endpoints

| Method | Endpoint                           | Description                 |
| ------ | ---------------------------------- | --------------------------- |
| POST   | `/api/Product`                     | Add a new product           |
| GET    | `/api/Product`                     | Get all products            |
| GET    | `/api/Product/{id}`                | Get a product by ID         |
| GET    | `/api/Product/category/{category}` | Search products by category |
| PUT    | `/api/Product/{id}`                | Update a product            |
| DELETE | `/api/Product/id/{id}`                | Delete a product            |

## API Testing

The API endpoints were tested using **Postman**.

### 1. Add Product

**POST**

```text
/api/Product
```

Request body:

```json
{
  "productId": 101,
  "productName": "Keyboard",
  "category": "Accessories",
  "price": 3100,
  "quantity": 10
}
```

Screenshot:

<img width="701" height="275" alt="image" src="https://github.com/user-attachments/assets/ac0eae90-617f-4974-836d-c7f691394956" />

---

### 2. Get All Products

**GET**

```text
/api/Product
```

Screenshot:

<img width="708" height="338" alt="image" src="https://github.com/user-attachments/assets/3a16db74-ef86-4057-929f-06624704fefa" />

---

### 3. Get Product by ID

**GET**

```text
/api/Product/101
```

Screenshot:

<img width="702" height="322" alt="image" src="https://github.com/user-attachments/assets/649eac7d-2943-43f5-8440-05d09c7b28a8" />

---

### 4. Update Product

**PUT**

```text
/api/Product/101
```

Request body:

```json
{
  "productId": 1,
  "productName": "Normal Keyboard",
  "category": "Accessories",
  "price": 3499,
  "quantity": 20
}
```

Screenshot:

<img width="718" height="281" alt="image" src="https://github.com/user-attachments/assets/4ea3a921-8f30-4baa-b4e9-74172da6d1e3" />


---

### 5. Search Product by Category

**GET**

```text
/api/Product/category/Accessories
```

Screenshot:

<img width="672" height="291" alt="image" src="https://github.com/user-attachments/assets/356acc09-5937-422d-8264-906e5faff577" />


---

### 6. Delete Product

**DELETE**

```text
/api/Product/101
```

Screenshot:

<img width="715" height="226" alt="image" src="https://github.com/user-attachments/assets/ef32c406-61e1-4e28-abf1-c28f89a0d8a3" />


---

### 7. Product Validation

The API validates product input using **Data Annotation attributes**.

Validation rules:

* Product name is required
* Category is required
* Price must be greater than `0`
* Quantity cannot be negative

Example invalid request:

```json
{
  "productId": 10,
  "productName": "",
  "category": "",
  "price": -500,
  "quantity": -2
}
```

The API returns:

```text
400 Bad Request
```

Screenshot:

<img width="830" height="585" alt="image" src="https://github.com/user-attachments/assets/c042e799-4572-419c-ba98-5a5c3e36909e" />

## Validation Implementation

Validation is implemented using Data Annotations in the `Product` model.

```csharp
[Required(ErrorMessage = "Product name is required")]
public string ProductName { get; set; }

[Required(ErrorMessage = "Category is required")]
public string Category { get; set; }

[Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
public decimal Price { get; set; }

[Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
public int Quantity { get; set; }
```

The Controller uses `[ApiController]`, which enables automatic model validation and returns `400 Bad Request` when the request data is invalid.

## Dependency Injection

The project uses ASP.NET Core Dependency Injection to connect interfaces with their implementations.

```csharp
builder.Services.AddSingleton<IProductRL, ProductRL>();
builder.Services.AddScoped<IProductBL, ProductBL>();
```

The dependency flow is:

```text
ProductController
       ↓
    IProductBL
       ↓
    ProductBL
       ↓
    IProductRL
       ↓
    ProductRL
```

## HTTP Status Codes

The API uses HTTP status codes to represent the result of an operation.

| Status Code       | Usage                         |
| ----------------- | ----------------------------- |
| `200 OK`          | Successful request            |
| `201 Created`     | Resource successfully created |
| `400 Bad Request` | Invalid request data          |
| `404 Not Found`   | Product does not exist        |

## How to Run

### Prerequisites

* .NET SDK
* Visual Studio or another compatible IDE
* Postman

### Steps

1. Clone the repository.

2. Open the project in Visual Studio.

3. Restore the project dependencies.

4. Build the project.

5. Run the application.

6. Copy the HTTPS URL shown by the application.

7. Open Postman and test the API endpoints.

Example:

```text
https://localhost:7224/api/Product
```

> The port number may be different depending on the local configuration.

## Data Storage

This project currently uses an in-memory `List<Product>` for storing product data.

```csharp
private List<Product> products;
```

The data is stored only while the application is running. Restarting the application clears the product data.

## Learning Outcomes

Through this project, I practiced:

* Building RESTful APIs using ASP.NET Core
* Implementing CRUD operations
* Creating Controllers
* Using interfaces and dependency injection
* Separating business logic from data access
* Implementing Repository and Business layers
* Model validation using Data Annotations
* Working with HTTP methods and status codes
* Testing APIs using Postman
* Organizing a backend project using layered architecture

## Future Improvements

The project can be extended by:

* Connecting PostgreSQL or SQL Server for persistent storage
* Using Entity Framework Core
* Adding DTOs
* Adding global exception handling
* Adding logging
* Adding authentication and authorization
* Adding unit tests
* Adding Swagger/OpenAPI documentation
