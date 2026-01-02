# AI Education Platform – Backend API

A backend REST API for an AI-powered education platform built with **ASP.NET Core** and **Entity Framework Core**.

This project is designed to manage users, courses, sections, and enrollments in a clean and scalable architecture.

---

## 🚀 Features

- User management (Students & Instructors)
- Course creation and listing
- Course sections
- User enrollments
- SQL Server database with Entity Framework Core
- Swagger UI for API testing
- Clean layered architecture

---

## 🏗 Project Architecture

AI.EducationPlatform
│
├── Application
│ ├── DTOs
│ ├── Interfaces
│ └── Services
│
├── Controllers
│ ├── UsersController
│ ├── CoursesController
│ ├── SectionsController
│ └── EnrollmentsController
│
├── Domain
│ ├── Entities
│ └── Enums
│
├── Infrastructure
│ ├── Data
│ │ ├── AppDbContext.cs
│ │ └── DbSeeder.cs
│ └── Repositories
│
├── Migrations
├── Program.cs
└── appsettings.json


---

## 🧰 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- .NET 9

---

## 🔍 API Endpoints (Examples)

- `GET /api/users`
- `POST /api/users`
- `GET /api/courses`
- `POST /api/courses`
- `GET /api/sections/course/{courseId}`
- `POST /api/enrollments`

Swagger UI available at:
/swagger


---

## 📌 Current Status

✔ Database created  
✔ Migrations applied  
✔ Core APIs implemented  
✔ Swagger integration  

This project is under active development and will be extended with authentication, roles, and AI-related features.

---

## 👨‍💻 Author

**Saif**  
Backend Developer | ASP.NET Core | Entity Framework  

Feel free to explore, fork, or provide feedback.
