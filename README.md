# CozyBeans - E-Commerce Backend Infrastructure

![Build Status](https://img.shields.io/badge/build-passing-brightgreen) ![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8.1-blue) ![Architecture](https://img.shields.io/badge/Architecture-Hexagonal-orange)

## 📖 Overview

**CozyBeans** is a conceptual e-commerce project designed for a coffee bean retailer. This repository hosts the **backend infrastructure** and **data access layer**, demonstrating a decoupled, maintainable, and testable architecture without a graphical user interface (GUI).

The primary goal of this project is to showcase advanced architectural patterns implementation on a strictly typed legacy framework (.NET 4.8.1), focusing on **separation of concerns** and **domain-driven design principles**.

## 🏗 Architecture & Design Patterns

The project follows the **N-Tier** approach integrated with **Hexagonal Architecture (Ports and Adapters)** to ensure that the business logic remains independent of external frameworks and databases.

Key patterns implemented:

* **Hexagonal Architecture:** Decouples the core domain from the infrastructure layer.
* **Generic Repository Pattern:** Provides a standardized abstraction for data access, reducing code duplication.
* **Unit of Work:** Ensures transaction management and data integrity.
* **Dependency Injection (via Interfaces):** Promotes loose coupling between layers.

## 🛠 Tech Stack

* **Framework:** .NET Framework 4.8.1
* **ORM:** Entity Framework 6.5.1
* **Language:** C#
* **Database:** MS SQL Server (Code-First Approach)

## 📂 Project Structure

The solution is organized to reflect the architectural layers:

* **CozyBeans.Core (Domain Layer):** Contains entities (POCOs), interfaces (Ports), and domain logic. Dependencies: *None*.
* **CozyBeans.Data (Infrastructure Layer):** Implements the interfaces defined in the Core using Entity Framework (Adapters). Contains the `DbContext`, Migrations, and Repository implementations.
* **CozyBeans.Service (Application Layer):** (Optional) Orchestrates the flow of data between the UI/API and the Data layer.

## 🚀 Key Features

- [x] Fully generic repository implementation (`IRepository<T>`).
- [x] Entity configurations using Fluent API.
- [x] Abstraction of database context.
- [x] Ready for Dependency Injection integration (e.g., Autofac or Unity).

## 📝 Usage

This project is a backend foundation. To use it:

1.  Clone the repository.
2.  Update the **Connection String** in `App.config` to point to your local SQL Server instance.
3.  Run the **Package Manager Console** command to create the database:
    ```powershell
    Update-Database
    ```
4.  You can instantiate the repositories through the defined interfaces to manipulate data programmatically.

## 👨‍💻 Author

Developed by **[Senin Adın/Kullanıcı Adın]** for educational and portfolio purposes.

---
*Note: This project focuses solely on the backend architecture and data modeling. No frontend or API layer is included.*
