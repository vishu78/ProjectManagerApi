# 🧩 Project Manager API (.NET 8 + JWT + In-Memory DB)

A lightweight full-stack backend built with **.NET 8 Web API** for managing projects and tasks — including user authentication with **JWT**, per-user data isolation, and **in-memory database** for easy testing.

---

## 🚀 Features

### 🔐 Authentication
- User registration and login using **JWT (JSON Web Tokens)**  
- Each user can access **only their own data**

### 📁 Projects
- Create, read, and delete projects  
- Each project includes:
  - `Title` (required, 3–100 characters)
  - `Description` (optional, up to 500 characters)
  - `CreatedAt` (set automatically)

### ✅ Tasks
- Each project contains multiple tasks  
- Each task includes:
  - `Title` (required)
  - `DueDate` (optional)
  - `IsCompleted` (toggle completion)
  - Reference to its parent project

### 🧰 Technical Highlights
- Built on **.NET 8 Web API**
- Uses **Entity Framework Core (InMemory Provider)**
- Modular architecture: **Controllers**, **Services**, **DTOs**, **Models**
- **JWT-based Authentication**
- **DataAnnotations** for validation
- **Swagger (OpenAPI)** integrated for testing endpoints

---

