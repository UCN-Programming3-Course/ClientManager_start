## Exercise 1 - ADO.NET

You are working as a software developer. Your team is developing an application that can manage a customer database and your task is to implement the database operations in the application layer. 

You will find the applications Data Access Layer (DAL) in this Visual Studio solution, where you must implement the CRUD methods.

**HINT!** The methods that you must implement are marked with a *TODO* comment

You can create the database table with the script below:

```
CREATE TABLE [dbo].[Customers]
(
    [Id] INT NOT NULL PRIMARY KEY, 
    [Firstname] NVARCHAR(50) NULL, 
    [Lastname] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NULL, 
    [Zip] NVARCHAR(6) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(20) NULL, 
    [Email] NVARCHAR(50) NULL
)
```

