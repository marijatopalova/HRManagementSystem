# HR Management System

## Overview

The **HR Management System** is a robust and scalable solution for managing employee data, leave requests, payroll, and department organization within an organization. Built using **ASP.NET Core Web API**, it follows best practices like **Clean Architecture**, **CQRS (Command Query Responsibility Segregation)**, and **MediatR** to ensure high maintainability, testability, and separation of concerns.

This project is designed to meet the essential needs of HR departments, ensuring efficient employee management, secure access control, and easy extendibility for future features.

## Key Features

- **Employee Management**: Manage employee records, roles, and track performance across departments.
- **Leave Management**: Allows employees to submit leave requests and managers to approve/reject them.
- **Payroll System**: Automates payroll calculations based on employee attendance and leave.
- **Department Management**: Organize employees into departments, manage department-specific settings.
- **Extensible Design**: Easily extend the application with new features using CQRS and MediatR patterns.
- **Fluent Validation**: Ensures consistent and centralized validation of inputs, making the application secure and user-friendly.
  
## Architecture

The system is based on the **Clean Architecture** principles, ensuring separation of concerns and facilitating test-driven development.

### Layers:

1. **Domain Layer**: Contains core business logic and entity definitions.
2. **Application Layer**: Implements use cases (commands/queries) and validation. Includes business rules using CQRS and MediatR.
3. **Infrastructure Layer**: Contains data access (EF Core), external services (like email), and repository implementations.
4. **API Layer**: The entry point of the system, exposes RESTful endpoints to handle requests, and interacts with the Application layer.

### Technologies Used

- **.NET 8**
- **Entity Framework Core**
- **CQRS and MediatR**
- **FluentValidation**
- **SQL Server** (or any other database provider)
- **Docker** support for containerized deployment
