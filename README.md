🔐 Authentication & Authorization API – ASP.NET Core (.NET 9)

A secure, scalable authentication and authorization REST API built using ASP.NET Core (.NET 9) and Entity Framework Core.
This project implements JWT-based authentication and follows clean architecture principles with a clear separation between controllers, services, DTOs, and data models.

📌 Features

User Registration & Login

JWT-based Authentication & Authorization

Secure Password Hashing

Protected API endpoints using [Authorize]

Entity Framework Core with SQL Server

Code First Migrations

Clean layered architecture

Dependency Injection

Centralized configuration using appsettings.json

🧱 Project Structure
AuthAPI
│
├── Controllers
│   └── AuthController.cs
│
├── Services
│   └── AuthService.cs
│
├── DTOs
│   ├── RegisterDto.cs
│   └── LoginDto.cs
│
├── Models
│   └── User.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── README.md

🔑 Authentication Flow

User registers with username and password

Password is securely hashed and stored in the database

User logs in using valid credentials

API generates a JWT token

Token is used to access protected endpoints

Authorization is enforced using [Authorize]

🛠️ Tech Stack

ASP.NET Core (.NET 9)

Entity Framework Core

SQL Server

JWT (JSON Web Tokens)

C#

RESTful APIs

⚙️ Configuration

Update the appsettings.json file:

"AppSettings": {
  "Token": "YOUR_SECURE_JWT_SECRET_KEY",
  "Issuer": "YourAppName",
  "Audience": "YourAudience"
},
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=authDB;Trusted_Connection=True;"
}


⚠️ Important: Never commit real secrets to source control.
Use environment variables or secret managers for production.

🗄️ Database Setup

Ensure SQL Server is running

Update the connection string

Run migrations:

Add-Migration InitialCreate
Update-Database

🔐 API Endpoints
Method	Endpoint	Description	Authorization
POST	/api/auth/register	Register a new user	❌ No
POST	/api/auth/login	Login and get JWT token	❌ No
GET	/api/auth/test	Protected test endpoint	✅ Yes
🧪 Security Highlights

Passwords are hashed before storage

JWT tokens are signed and validated

Sensitive data is never exposed via DTOs

Authentication logic isolated in service layer

🚀 Running the Project
dotnet restore
dotnet run


Access Swagger UI:

https://localhost:{port}/swagger

🔮 Future Improvements

Refresh Tokens

Role-based Authorization

Email Verification

Password Reset

Swagger JWT Authorization

Unit & Integration Tests

🧑‍💻 Author

Built as a learning-focused, production-aligned authentication API to demonstrate backend development skills, security best practices, and clean architecture principles.

⭐ Why This Project?

Real-world authentication flow

Interview-ready backend project

Solid foundation for enterprise APIs

Easy to extend and maintain
