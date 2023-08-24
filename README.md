# Northwind Product Query

This project is a simple console application that uses Entity Framework Core, SQL Server, and LINQ to query, group, join, filter and sort products from the Northwind database and outputs them in a console with page navigation.

## Prerequisites
- C# 11 or higher
- .NET 7.0 or higher
- SQL Server
- Northwind database

## Setup

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Update the connection string in `Northwind.cs` to point to your SQL Server instance and Northwind database.
4. Build and run the project.

## Usage

When you run the application, you will be shown a message saying connection to db succeeded upon establishing the connection. The application will then query the products from the Northwind database and display them in the console with the specified page size and page number.

You can navigate through the pages by pressing left or right arrow. To exit the application, press any other key.

In addition to basic pagination, this version of the application also includes group, join, filter, and sort features. You can use these features by uncommenting the methods in `program.cs` file.
