EnterpriseApp

A company management web application built with ASP.NET Core 9.0 MVC and Entity Framework Core 9.0, demonstrating practical concepts such as relational data modeling, Partial Views, View Components, and AJAX-based data fetching with a Microsoft SQL Server database.

📋 Project Description

EnterpriseApp is an educational enterprise management application designed to demonstrate how modern ASP.NET Core MVC applications can be structured and developed using Entity Framework Core and SQL Server.

The project focuses on managing and displaying company-related data such as employees, departments, and projects while demonstrating reusable UI components and asynchronous client-side communication.

It combines server-side MVC architecture with modern frontend techniques, including Razor Views, Partial Views, View Components, Bootstrap, and the JavaScript Fetch API.

The project is designed to provide practical experience with building structured, database-driven web applications using the ASP.NET Core ecosystem.

👨‍💻 Author

Ahmed Agwa

✨ Features

- Employee Management
  
  - Displays employee information using a reusable "EmployeeCard" Partial View.
  - Retrieves employee data from the SQL Server database using Entity Framework Core.

- Department Management
  
  - Works with department-related company data.
  - Demonstrates relationships between departments and employees.

- Company Statistics Widget
  
  - Implemented using a reusable "CompanyDataViewComponent".
  - Displays:
    - Total number of employees
    - Total number of departments
    - Average employee salary

- AJAX Data Fetching
  
  - Uses the JavaScript Fetch API to retrieve employee data asynchronously.
  - Data is returned through the "/Employees/GetEmployeesAjax" JSON endpoint.
  - Results are rendered dynamically without requiring a full page reload.

- Relational Data Model
  
  - Departments
  - Employees
  - Projects
  - EmployeeProjects
  - Many-to-many relationship between employees and projects
  - Project role assignments

- Reusable UI Components
  
  - Partial Views for reusable employee cards.
  - View Components for displaying company statistics.

🗂️ Project Structure

EnterpriseApp/
├── Controllers/
│   ├── EmployeesController.cs
│   └── DepartmentController.cs
├── Models/
│   ├── Department.cs
│   ├── Employee.cs
│   ├── Project.cs
│   └── EmployeeProject.cs
├── ViewComponents/
│   └── CompanyDataViewComponent.cs
├── Data/
│   └── EnterpriseDbContext.cs
├── Views/
│   ├── Employees/
│   │   ├── Index.cshtml
│   │   └── _EmployeeCard.cshtml
│   ├── Department/
│   │   └── TestAjax.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── Components/
│           └── CompanyData/
│               └── Default.cshtml
└── Program.cs

🛠️ Tech Stack

- Framework: ASP.NET Core 9.0 MVC
- Programming Language: C#
- ORM: Entity Framework Core 9.0
- Database: Microsoft SQL Server
- Frontend: Razor Views, Bootstrap, HTML5, CSS3
- Client-side: Vanilla JavaScript
- Data Fetching: JavaScript Fetch API
- IDE: Visual Studio 2022+

🚀 Getting Started

Prerequisites

Before running the project, make sure you have:

- Visual Studio 2022 or later
- ASP.NET and web development workload
- .NET 9.0 SDK
- Microsoft SQL Server
- SQL Server Management Studio (SSMS) is recommended

Installation

1. Clone the Repository

git clone https://github.com/<your-username>/EnterpriseApp.git
cd EnterpriseApp

2. Create the Database

Run the SQL script included in the project's "Database" folder against your SQL Server instance.

The script creates the required EnterpriseDB database, tables, relationships, and sample data.

3. Configure the Connection String

Open "appsettings.json" and update the connection string according to your SQL Server instance:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EnterpriseDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}

4. Restore NuGet Packages

dotnet restore

5. Build the Project

dotnet build

6. Run the Application

dotnet run

You can also run the application directly from Visual Studio by pressing F5.

📸 Application Pages

Route| Description
"/Employees/Index"| Displays the employee list using Partial Views.
"/Department/TestAjax"| Demonstrates asynchronous employee data fetching using AJAX.

🔗 Main Concepts Demonstrated

This project demonstrates practical implementation of:

- ASP.NET Core MVC architecture
- Entity Framework Core
- SQL Server database integration
- Entity relationships
- Controllers and Actions
- Razor Views
- Partial Views
- View Components
- Dependency Injection
- JSON endpoints
- AJAX / Fetch API
- Reusable UI components
- Database-driven web applications

🎯 Project Purpose

The main purpose of EnterpriseApp is to provide practical experience in developing a structured ASP.NET Core MVC enterprise-style application.

It demonstrates how backend database operations, MVC architecture, reusable UI components, and asynchronous JavaScript communication can work together in a single application.

📄 License

This project is intended for educational purposes.

---

Author: Ahmed Agwa
