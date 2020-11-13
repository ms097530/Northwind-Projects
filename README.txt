Summary of repository structure

- Northwind.db is a database created from Northwind.sql, provided by Mark J. Price in "C# 8.0 and .NET Core 3.0 - Modern Cross-Platform Development, 4th Edition"
  - it is already populated with a decent amount of values so that it can be worked with for educational purposes
- NorthwindContextLib contains the structure for the Northwind class which represents the database
- NorthwindEntitiesLib contains classes to represent data imported from the Northwind database
- NorthwindWeb is a website built using Razor pages, largely code that is used throughout the book
- NorthwindEmployees is a Razor class library added through Ch. 15 of the book
- NorthwindCustomers is a Razor class library implemented by myself as part of a project in Ch. 15
- NorthwindMvc is a separate website from NorthwindWeb that is built using ASP.NET Core MVC
  - the CustomerDetail section was implemented by myself
