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

  ### Screenshots
  <img width="1366" height="768" alt="Screenshot (183)" src="https://github.com/user-attachments/assets/eaeadbd9-eca9-4f26-aece-5608f665b459" />
  <img width="1366" height="768" alt="Screenshot (185)" src="https://github.com/user-attachments/assets/edfbe92c-f0c5-4d55-bfec-27ec5d561b00" />
  <img width="1366" height="768" alt="Screenshot (187)" src="https://github.com/user-attachments/assets/b5f55e60-8fcc-4728-85e0-126d5abc8586" />
  <img width="1366" height="768" alt="Screenshot (189)" src="https://github.com/user-attachments/assets/c6b56f98-a11b-4b27-8665-b1bc94586b8f" />
  <img width="1366" height="768" alt="Screenshot (192)" src="https://github.com/user-attachments/assets/8f4dfcc6-991c-42bd-b38f-0b2b1c7e1043" />






---

