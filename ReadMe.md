# Sarasavi LMS (Library Management System)

## Overview

The Sarasavi LMS is a Library Management System designed to handle various operations within a library, including book management, user management, loans, reservations, and inquiries. This system is built using Windows Forms and SQL Server Express for the database backend.

## Prerequisites

Before you begin, ensure you have the following software installed:

- **SQL Server Express**: A free edition of SQL Server for small-scale applications.
- **SQL Server Management Studio (SSMS)**: A tool to manage your SQL Server instances.

## Database Setup

To get started with Sarasavi LMS, you need to set up the necessary database tables. Below are the steps to create the database tables required for the application.

### 1. Install SQL Server Express and SSMS

- Download and install [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
- Download and install [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

### 2. Create the Database Tables

Open SQL Server Management Studio and connect to your SQL Server instance. Then, execute the following SQL scripts to create the necessary tables for the application.

#### User Table

```sql
CREATE TABLE [User] (
    UserId INT PRIMARY KEY IDENTITY(1,1), -- Auto-incremented primary key
    Name NVARCHAR(100) NOT NULL,          -- Name of the user
    Sex CHAR(1) NOT NULL,                 -- Sex (e.g., 'M' for Male, 'F' for Female)
    NIC NVARCHAR(12) NOT NULL,            -- National Identity Card Number
    Address NVARCHAR(255) NOT NULL,       -- Residential Address
    Role NVARCHAR(50) NOT NULL            -- Role (e.g., 'Member', 'Visitor', etc.)
);
```

#### Book Table

```sql
CREATE TABLE Book (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255) NOT NULL,
    ISBN NVARCHAR(20) NOT NULL,
    Publisher NVARCHAR(100) NOT NULL,
    Classification NVARCHAR(10) NOT NULL
);
```

#### Copy Table

```sql
CREATE TABLE Copy (
    CopyId INT PRIMARY KEY IDENTITY(1,1),
    BookId INT NOT NULL FOREIGN KEY REFERENCES Book(BookId),
    CopyNumber INT NOT NULL,
    IsReference BIT NOT NULL,  -- 1 for Reference copy, 0 for Borrowable copy
    Status NVARCHAR(50) NOT NULL  -- e.g., 'Available', 'Loaned', 'Reserved'
);
```

#### Loan Table

```sql
CREATE TABLE Loan (
    LoanId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    CopyId INT NOT NULL FOREIGN KEY REFERENCES Copy(CopyId),
    LoanDate DATETIME NOT NULL,
    ReturnDate DATETIME NULL,  -- Nullable to allow for not yet returned books
    DueDate DATETIME NOT NULL
);
```

#### Reservation Table

```sql
CREATE TABLE Reservation (
    ReservationId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    BookId INT NOT NULL FOREIGN KEY REFERENCES Book(BookId),
    ReservationDate DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL  -- e.g., 'Pending', 'Fulfilled', 'Cancelled'
);
```

#### Inquiry Table

```sql
CREATE TABLE Inquiry (
    InquiryId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    BookId INT NOT NULL FOREIGN KEY REFERENCES Book(BookId),
    InquiryDate DATETIME NOT NULL,
    InquiryDetails NVARCHAR(255) NOT NULL
);
```

## Getting Started

Once the database setup is complete, you can proceed with the following steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Configure the database connection string in `App.config` or the relevant configuration file.
4. Build and run the project.

## Features

- **User Management**: Register, login, and manage users with different roles.
- **Book Management**: Add, update, and delete books from the library's collection.
- **Loan Management**: Borrow and return books.
- **Reservation Management**: Reserve books and manage reservations.
- **Inquiry Management**: Submit and track inquiries related to books.

## Contributing

If you'd like to contribute to the project, feel free to submit a pull request or open an issue.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
