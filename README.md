# 🧱 2025 Clean Architecture Setup – Cargo Tracking System

This repository provides a **modern**, **modular**, and **extensible Clean Architecture setup** tailored for 2025 enterprise projects.  
The initial implementation focuses on a **Cargo Tracking System**, serving as a scalable template for future modules.

---

## 🧱 Architectural Overview

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
![image_alt](https://github.com/dogukanzorer/CargoTrackingDevOps/blob/4938abbb4028e7de9b2154eb80449e7ce7492c23/num1.png)
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
