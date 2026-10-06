# Ocelot API Gateway — Mini Project

## 1. Project Structure

```text
OcelotMicroservices
│
├── UserService
│   └── UserController.cs
│
├── ProductService
│   └── ProductController.cs
│
└── ApiGateway
    ├── Program.cs
    └── ocelot.json
```

## 2. Ports

| Project        | Port   |
| -------------- | ------ |
| API Gateway    | `7174` |
| UserService    | `7176` |
| ProductService | `7284` |

---

## 3. Overall Flow

```text
                    Client
                      │
                      │ Request
                      ▼
              ┌─────────────────┐
              │   API Gateway   │
              │     Ocelot      │
              │     :7174       │
              └────────┬────────┘
                       │
             ┌─────────┴─────────┐
             │                   │
             ▼                   ▼
      ┌─────────────┐     ┌──────────────┐
      │ UserService │     │ProductService│
      │    :7176    │     │    :7284     │
      └─────────────┘     └──────────────┘
```

The client communicates with the **API Gateway**, rather than directly calling each microservice.

---

# 4. User Request Flow

Client sends:

```text
GET https://localhost:7174/users
```

### Step 1 — Request reaches API Gateway

Ocelot receives:

```text
/users
```

This is called the **Upstream Path**.

### Step 2 — Ocelot checks `ocelot.json`

Ocelot finds the matching route:

```text
/users
      ↓
/api/users
```

### Step 3 — Ocelot forwards the request

It sends the request to:

```text
https://localhost:7176/api/users
```

This is the **Downstream Path**.

### Step 4 — UserService processes the request

`UserController` handles:

```text
GET /api/users
```

and returns the response.

### Step 5 — Response goes back through Gateway

```text
UserService
     ↓
API Gateway
     ↓
Client
```

---

# 5. Product Request Flow

Client sends:

```text
GET https://localhost:7174/products
```

Ocelot checks its configuration and maps:

```text
Upstream:
    /products

        ↓

Downstream:
    /api/products
```

Then Ocelot forwards the request to:

```text
https://localhost:7284/api/products
```

The response follows:

```text
ProductService
      ↓
API Gateway
      ↓
Client
```

---

# 6. `ocelot.json`

This file contains the **routing configuration** for Ocelot.

Example:

```json
{
  "Routes": [
    {
      "DownstreamPathTemplate": "/api/users",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7176
        }
      ],
      "UpstreamPathTemplate": "/users",
      "UpstreamHttpMethod": [ "GET" ]
    }
  ]
}
```

### Important terms

**Upstream**

The URL exposed by the API Gateway to the client.

```text
/users
```

**Downstream**

The actual microservice endpoint.

```text
/api/users
```

**DownstreamHostAndPorts**

Specifies where the microservice is running.

```text
localhost:7176
```

**DownstreamScheme**

Specifies the protocol.

```text
https
```

**UpstreamHttpMethod**

Specifies which HTTP method is allowed.

```text
GET
```

---

# 7. `Program.cs`

The Gateway registers Ocelot:

```csharp
builder.Configuration.AddJsonFile("ocelot.json");

builder.Services.AddOcelot();

var app = builder.Build();

await app.UseOcelot();

app.Run();
```

### What each line does

```csharp
builder.Configuration.AddJsonFile("ocelot.json");
```

Loads the Ocelot routing configuration.

```csharp
builder.Services.AddOcelot();
```

Registers Ocelot services in the application.

```csharp
await app.UseOcelot();
```

Adds Ocelot to the request pipeline so it can process and route incoming requests.

---

# 8. Final Flow to Remember

```text
Client
  │
  │ GET /users
  ▼
API Gateway :7174
  │
  │ Ocelot checks ocelot.json
  │
  │ /users → /api/users
  ▼
UserService :7176
  │
  │ Response
  ▼
API Gateway :7174
  │
  ▼
Client
```

For products:

```text
Client
  │
  │ GET /products
  ▼
API Gateway :7174
  │
  │ /products → /api/products
  ▼
ProductService :7284
  │
  │ Response
  ▼
API Gateway :7174
  │
  ▼
Client
```


