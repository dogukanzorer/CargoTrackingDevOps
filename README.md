# 🧱 Clean Architecture - Cargo Tracking System (2025)

A modern **Clean Architecture** starter project for building modular, maintainable, and scalable enterprise applications using **.NET 8**. This project implements a **Cargo Tracking System** as a sample module and is built to be extended with additional bounded contexts like Authentication, User Management, and more.

Clean Architecture is also known as:
- Hexagonal Architecture
- Ports-and-Adapters
- Onion Architecture

---

## 📋 Table of Contents

- [Give a Star ⭐](#give-a-star-)
- [Versions](#versions)
- [Getting Started](#getting-started)
- [Architecture Overview](#architecture-overview)
- [Project Structure](#project-structure)
- [Libraries Used](#libraries-used)
- [Future Modules](#future-modules)

---

## ⭐ Give a Star ⭐

### 🧭 Architecture Pattern
- **Clean Architecture**

### 🎯 Design Patterns
- Result Pattern  
- Repository Pattern  
- CQRS Pattern  
- Unit of Work Pattern  

---

## 🧰 Libraries & Technologies

| Library / Tool | Purpose |
|----------------|---------|
| **.NET 8** | Framework |
| **MediatR** | CQRS and messaging |
| **TS.Result** | Result modeling |
| **Mapster** | Object mapping |
| **FluentValidation** | Validation logic |
| **EntityFrameworkCore** | ORM |
| **OData** | Query flexibility |
| **Scrutor** | Dependency injection |

---
<img src="https://github.com/dogukanzorer/CargoTrackingDevOps/raw/4938abbb4028e7de9b2154eb80449e7ce7492c23/num1.png" alt="Cargo Tracking Giriş" width="300" height="550">
## 🔧 Implementation Progress

### ✅ Step 1: Cargo Tracking Module

#### 📦 Domain Layer
- **Entities & Value Objects**:
  - `Cargo` (Main entity)
  - `Address` (Value object)
  - `Person` (Value object)
  - `CargoTypeEnum` (Enum)
- **Abstractions**:
  - `ICargoRepository`
- **DTOs**:
  - `ErrorResponseDto`
  - `BadRequestErrorResponseDto`

#### ⚙️ Application Layer (CQRS)
- **Commands & Queries**:
  - `CargoCreateCommand`
  - `CargoGetAllQuery`
- **Validation**: `FluentValidation`
- **Mapping**: `Mapster`

#### 🛠️ Infrastructure Layer
- **Repository**: `CargoRepository`
- **EF Core**:
  - `CargoConfiguration` (Entity mapping)
- **DI**: `Scrutor` for service registration

#### 🌐 WebAPI Layer
- **OData Endpoints**:
  - `GET /odata/cargos` (List all)
  - `POST /odata/cargos` (Create)
- **API Versioning**: Configured

---

> ✅ **Upcoming**: Cargo detail/update/delete, authentication, Swagger integration.
